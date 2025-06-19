using OrderTrack.Data.Context_s; // namespace untuk akses ke class AppDbContext untuk sesi ke DB
using OrderTrack.Models_s; // namespace untuk akses beberapa class models yang mewakili tabel DB
using OrderTrack.utils; // untuk class-class utilitas

// menyesuaikan assembly dari path folder nya yakni OrderTrack/view/UserControls
namespace OrderTrack.view.UserControls
{
    // class inti dari UC ini dengan penerapan inheritance ke BaseUserControl
    public partial class UC_produk : BaseUserControl
    {
        public static UC_produk ActiveProdukInstance { get; set; }
        // Event untuk memberitahu MainView tentang update summary keranjang (real-time)
        public event EventHandler<CartSummaryUpdateEventArgs> CartSummaryUpdated;

        private readonly AppDbContext_s _dbcontext;
        public static List<Browny> _keranjangItems = new List<Browny>();
        /*
         *  Menyimpan daftar objek Browny yang ada di keranjang. 
         *  Ini adalah daftar statis, yang berarti datanya akan 
         *  tetap ada meskipun UC_produk di-unload dan di-load lagi (selama aplikasi berjalan).
         */
        public static Dictionary<int, int> _quantityKeranjang = new Dictionary<int, int>();
        /*
         * Menyimpan kuantitas untuk setiap Browny di keranjang. 
         * Key-nya adalah IdBrownies dan Value-nya adalah kuantitas. 
         * Ini juga statis.
         */
        public static Dictionary<int, QuantityBox> _quantityControls = new();
        /*
         *  Ini adalah kunci penting.
         *  Ia menyimpan referensi ke setiap QuantityBox yang dibuat di panel produk (sisi kiri) berdasarkan IdBrownies. 
         *  Ini memungkinkan Anda untuk memperbarui QuantityBox di panel produk saat kuantitas diubah dari sidebar keranjang, dan sebaliknya. Ini juga statis.
         */
        public UC_produk()
        {
            InitializeComponent(); // Menginisialisasi komponen UI (InitializeComponent()).
            _dbcontext = new AppDbContext_s(); // Membuat instance AppDbContext_s untuk mengakses database.

            LoadProdukData(); // Memanggil LoadProdukData() untuk memuat daftar produk ke UI.
            UpdateKeranjangSideBar(); // Memanggil UpdateKeranjangSideBar() untuk menginisialisasi tampilan keranjang
                                      // (mungkin ada item dari sesi sebelumnya atau keranjang yang masih kosong).
        }
        private void UpdateKeranjangSummaryLabels(decimal subtotal, decimal pajak, decimal ongkosKirim, decimal total)
        {
            // Pastikan nama-nama label ini sesuai dengan yang Anda buat di Designer.cs
            // dan berada di pnlSummaryCost dan pnlTotal
            lblSubTotalValue.Text = $"Rp. {subtotal:N0}";
            lblPajakValue.Text = $"Rp. {pajak:N0}";
            lblOngkirValue.Text = $"Rp. {ongkosKirim:N0}";
            lblTotalValue.Text = $"Rp. {total:N0}";

            OnCartSummaryUpdated(new CartSummaryUpdateEventArgs(subtotal, pajak, ongkosKirim, total));
        }
        // Metode pemicu event CartSummaryUpdated
        protected virtual void OnCartSummaryUpdated(CartSummaryUpdateEventArgs e)
        {
            CartSummaryUpdated?.Invoke(this, e);
        }
        public static void NotifyCartDataChange()
        {
            if (ActiveProdukInstance != null)
            {
                ActiveProdukInstance.PerformCartCalculationAndNotify();
            }
        }
        public void PerformCartCalculationAndNotify()
        {
            decimal subtotal = 0;
            // Hitung subtotal dari _keranjangItems dan _quantityKeranjang (data static)
            foreach (var item in _keranjangItems)
            {
                if (_quantityKeranjang.ContainsKey(item.IdBrownies) && _quantityKeranjang[item.IdBrownies] > 0)
                {
                    subtotal += (item.HargaBrownies * _quantityKeranjang[item.IdBrownies]);
                }
            }
            decimal pajakRate = 0.1m;
            // Perlu filter yang sama seperti di DisplayKeranjangItems() untuk ongkir
            // Cek jika _quantityKeranjang memiliki entri dengan kuantitas > 0
            bool hasActiveItems = _quantityKeranjang.Any(kv => kv.Value > 0);
            decimal ongkosKirim = hasActiveItems ? 12000m : 0m;
            decimal totalPajak = subtotal * pajakRate;
            decimal finalTotal = subtotal + totalPajak + ongkosKirim;

            // Panggil metode yang memperbarui UI dan memicu event
            UpdateKeranjangSummaryLabels(subtotal, totalPajak, ongkosKirim, finalTotal);
        }
        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            //_keranjangItems.Clear();
            //_quantityKeranjang.Clear();

            if (!_keranjangItems.Any(b => _quantityKeranjang.ContainsKey(b.IdBrownies) && _quantityKeranjang[b.IdBrownies] > 0))
            {
                MessageBox.Show("Tambahkan quantity di produk yang mau kamu beli yaa", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Yeay! brownies kamu sudah masuk keranjang, \njangan lupa checkout yaa :)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ... (kode pengecekan keranjang kosong, MessageBox.Show) ...

            UC_keranjang keranjang = new UC_keranjang();

            keranjang.LoadKeranjangDataAndDisplay();

            UC_produk.NotifyCartDataChange();

            // Sekarang, ketika berpindah ke UC_keranjang, kita ingin sidebar detail TIDAK muncul
            // asumsikan parameter kedua NavigationEventArgs adalah RequireSideBar (navigasi utama)
            // dan parameter ketiga adalah RequireDetail (sidebar keranjang/summary)
            OnNavigateToUserControlRequested(new NavigationEventArgs(keranjang, true)); 
        }
        private void QuantityBox_ValueChanged(object sender, EventArgs e)
        {
            QuantityBox changedQuantityBox = sender as QuantityBox;
            if (changedQuantityBox == null)
            {
                return;
            }

            int idBrownies = (int)changedQuantityBox.Tag;
            int newQuantity = changedQuantityBox.Value;

            // Ambil item brownies yang sesuai dari database (jika belum ada di _keranjangItems)
            Browny brownies = _dbcontext.Brownies.FirstOrDefault(b => b.IdBrownies == idBrownies);
            if (brownies == null)
            {
                MessageBox.Show("Produk tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newQuantity > 0)
            {
                // Update kuantitas di dictionary
                _quantityKeranjang[idBrownies] = newQuantity;

                // Tambahkan ke _keranjangItems jika belum ada
                if (!_keranjangItems.Any(b => b.IdBrownies == idBrownies))
                {
                    _keranjangItems.Add(brownies);
                }
            }
            else // newQuantity adalah 0
            {
                // Hapus dari _keranjangItems dan _quantityKeranjang
                _keranjangItems.RemoveAll(b => b.IdBrownies == idBrownies);
                _quantityKeranjang.Remove(idBrownies);
            }

            // PENTING: Panggil UpdateKeranjangSideBar() untuk me-refresh UI keranjang
            // Semua perhitungan subtotal, pajak, dll. akan dilakukan di sana.
            UpdateKeranjangSideBar();
        }
        public static List<Browny> GetKeranjangItems()
        {
            return _keranjangItems;
        }

        public static Dictionary<int, int> GetQuantityKeranjang()
        {
            return _quantityKeranjang;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePageUserControl homePage = new HomePageUserControl();

            OnNavigateToUserControlRequested(new(homePage, false));
        }
    }
}
