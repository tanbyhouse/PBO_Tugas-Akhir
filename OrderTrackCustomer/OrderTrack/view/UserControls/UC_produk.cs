using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing; // Untuk kelas Image, Bitmap, Point, Size
using System.IO;    // Untuk Path, Directory
using System.Linq;  // Untuk ToList(), FirstOrDefault(), Where()
using System.Threading.Tasks; // Untuk async/await jika menggunakan ToListAsync()
using OrderTrack.Data.Context_s;
using OrderTrack.Models_s;
using OrderTrack.utils;
using OrderTrack.view.UserControls;
using Microsoft.EntityFrameworkCore;


namespace OrderTrack.view.UserControls
{

    public partial class UC_produk : UserControl
    {
        private readonly AppDbContext_s _dbcontext;
        public EventHandler<NavigationEventArgs> NavigateToUserControlRequested;

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
        
        // SEMENTARA KU COMMENT KARENA HARUSNYA SUDAH TER DISPOSE

        //public static void ClearKeranjang()
        //{
        //    _keranjangItems.Clear();
        //    _quantityKeranjang.Clear();
        //}

        public UC_produk()
        {
            InitializeComponent(); // Menginisialisasi komponen UI (InitializeComponent()).
            _dbcontext = new AppDbContext_s(); // Membuat instance AppDbContext_s untuk mengakses database.

            LoadProdukData(); // Memanggil LoadProdukData() untuk memuat daftar produk ke UI.
            UpdateKeranjangSideBar(); // Memanggil UpdateKeranjangSideBar() untuk menginisialisasi tampilan keranjang
                                      // (mungkin ada item dari sesi sebelumnya atau keranjang yang masih kosong).
        }

        // method yang menampilkan UI dinamis sesuai dari objek data di database 
        private async void LoadProdukData()
        {
            // langkah 1: mengambil data produk brownies dari class Browny
            List<Browny> brownieslist = new List<Browny>();
            try
            {
                brownieslist = await _dbcontext.Brownies.ToListAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Akhir Langkah 1

            // Langkah 2: Menangani kasus apabila tabel di database kosong (tidak ada data yang bisa dimuat)
            if (brownieslist == null || !brownieslist.Any())
            {
                Label lblNoData = new Label();
                lblNoData.Text = "Maaf, data produk belum tersedia.";
                lblNoData.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                lblNoData.AutoSize = true;
                lblNoData.TextAlign = ContentAlignment.MiddleCenter;
                this.produkLayoutPanel.Controls.Add(lblNoData);
                lblNoData.Anchor = AnchorStyles.None;
                return;
            }
            // Akhir Langkah 2

            // Langkah 3: mengatur data untuk gambar karena agak susah jika menyimpan bit data di db maka
            // disimpan dalam bentuk path yang disimpan di bin
            string imageBasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            // Akhir Langkah 3

            // Langkah 4: melakukan iterasi data yang telah diambil dari class Browny
            // membuat sebuah komponen UI dinamis dari masing-masing datanya secara manual
            foreach (var brownies in brownieslist)
            {
                RoundedPanel productPanel = new RoundedPanel();
                productPanel.CornerRadius = 15;
                productPanel.BorderColor = ColorTranslator.FromHtml("#e8e3cf");
                productPanel.BorderThickness = 1;
                productPanel.Size = new Size(180, 270);
                productPanel.BorderStyle = BorderStyle.None;
                productPanel.Margin = new Padding(5);
                productPanel.BackColor = ColorTranslator.FromHtml("#e8e3cf");
                productPanel.Tag = brownies;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(160, 140);
                pictureBox.BackColor = Color.Transparent;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Location = new Point(10, 30);

                string fullImagePath = Path.Combine(imageBasePath, brownies.GambarPath);
                if (File.Exists(fullImagePath))
                {
                    try
                    {
                        pictureBox.Image = Image.FromFile(fullImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Console.WriteLine($"File gambar tidak ditemukan: {fullImagePath}");
                    pictureBox.Image = new Bitmap(1, 1);
                }

                Label lblNama = new Label();
                lblNama.Text = brownies.NamaBrownies;
                lblNama.BackColor = Color.Tan;
                lblNama.Font = new Font("Gilroy-Bold", 10, FontStyle.Bold);
                lblNama.TextAlign = ContentAlignment.MiddleCenter;
                lblNama.Size = new Size(productPanel.Width, 30);

                Label lblHarga = new Label();
                lblHarga.Text = $"Rp. {brownies.HargaBrownies:N0}";
                lblHarga.TextAlign = ContentAlignment.MiddleCenter;
                lblHarga.Location = new Point((productPanel.Width - lblHarga.PreferredWidth) / 2, 170);
                lblHarga.AutoSize = true;
                lblHarga.BackColor = Color.Transparent;
                lblHarga.Font = new Font("Gilroy-Medium", 9, FontStyle.Regular);

                Button btnDetail = new Button();
                btnDetail.BackColor = Color.Tan;
                btnDetail.FlatStyle = FlatStyle.Flat;
                btnDetail.FlatAppearance.BorderSize = 0;
                btnDetail.ForeColor = ColorTranslator.FromHtml("#4D3B2F");
                btnDetail.Font = new Font("Gilroy-Bold", 10, FontStyle.Regular);
                btnDetail.Location = new Point(0, 195);
                btnDetail.Size = new Size(productPanel.Width, 30);
                btnDetail.Text = "Detail Produk";
                btnDetail.Click += (sender, e) => ShowProductDetail(brownies);

                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(lblNama);
                productPanel.Controls.Add(lblHarga);
                productPanel.Controls.Add(btnDetail);

                this.produkLayoutPanel.Controls.Add(productPanel);

                QuantityBox quantityBox = new QuantityBox();
                quantityBox.Minimum = 0;
                quantityBox.Maximum = 200;
                // Penting: Set nilai awal dari keranjang jika sudah ada
                quantityBox.Value = _quantityKeranjang.GetValueOrDefault(brownies.IdBrownies, 0); // Ambil kuantitas dari keranjang jika ada

                quantityBox.Location = new Point(15, 232);
                quantityBox.Name = "quantityBox_" + brownies.IdBrownies;
                quantityBox.Tag = brownies.IdBrownies; // PENTING: Set Tag agar QuantityBox_ValueChanged tahu produk mana

                // PENTING: Attach event handler di sini!
                quantityBox.ValueChanged += QuantityBox_ValueChanged; // Ini akan memicu update sidebar secara langsung

                _quantityControls[brownies.IdBrownies] = quantityBox;
                productPanel.Controls.Add(quantityBox);
            }
            // Akhir Langkah 4

            // Langkah 5: Setelah semua produk dimuat, perbarui sidebar untuk menampilkan item yang mungkin sudah ada di keranjang dari sesi sebelumnya
            UpdateKeranjangSideBar(); // Panggil di sini juga untuk inisialisasi awal
            // Akhir Langkah 5
        }

        // method untuk menampilkan UI sidebar sebelah kanan
        private void UpdateKeranjangSideBar()
        {
            // Langkah 6: Tiap method ini dipanggil, maka isi dari panel flowPanelKeranjangHostItems
            // akan dibersihkan untuk update tiap iterasinya
            flowPanelKeranjangHostItems.Controls.Clear();
            // Akhir langkah 6

            // Langkah 7: Inisialisasi tiap value dari variabel angka yang ada
            // saat pertama kali muncul maka semua akan di set ke 0
            decimal subtotal = 0;
            decimal pajakrate = 0.1m;
            decimal ongkir = 0m;
            // Akhir langkah 8

            // Langkah 8: memeriksa apakah sudah terdapat objek di _keranjangItems
            if (_keranjangItems.Any())
            {
                ongkir = 12000;
            }
            // Akhir langkah 8

            // Langkah 9: Ketika belum ada objek yang ditambahkan maka akan memberitahu kalau
            // keranjang masih kosong
            if (_keranjangItems.Count() == 0)
            {
                Label lblEmpty = new Label();
                lblEmpty.Text = "Keranjang Anda kosong.";
                lblEmpty.Font = new Font("Segoe UI", 10, FontStyle.Italic);
                lblEmpty.AutoSize = false;
                lblEmpty.Dock = DockStyle.Fill;
                lblEmpty.TextAlign = ContentAlignment.MiddleCenter;
                flowPanelKeranjangHostItems.Controls.Add(lblEmpty);

                UpdateKeranjangSummaryLabels(0, 0, 0, 0);
                return;
            }
            // Akhir langkah 9

            // Pastikan _keranjangItems memiliki item unik dan sesuai dengan _quantityKeranjang
            // Ada kemungkinan _keranjangItems memiliki duplikat jika item ditambahkan berulang kali
            // tanpa mekanisme pengecekan, atau jika kuantitas diubah ke 0 tetapi item tidak dihapus.
            // Filter item yang benar-benar ada di _quantityKeranjang dengan qty > 0.

            // Langkah 10: Melakukan filtering untuk UI. disini akan di check kebenaran terkait jumlah produk yang diambil
            // harus memenuhi dua syarat yakni memiliki id dan jumlahnya lebih dari 0 yang akan disimpan dalam bentuk
            // list di currentKeranjangItems
            var currentKeranjangItems = _keranjangItems
                .Where(item => _quantityKeranjang.ContainsKey(item.IdBrownies) && _quantityKeranjang[item.IdBrownies] > 0)
                .ToList();
            // Akhir langkah 10

            // Langkah 11: Mengatur UI untuk ditampilkan untuk setiap elemen di keranjang
            foreach (var item in currentKeranjangItems.OrderBy(b => b.NamaBrownies))
            {
                // membuat sebuah variabel untuk menyimpan nilai sesuai dengan id brownies nya
                int qty = _quantityKeranjang.GetValueOrDefault(item.IdBrownies, 0);
                lblPajakValue.Location = new Point(117, 34);
                lblOngkirValue.Location = new Point(117, 59);

                // Hanya proses jika kuantitas lebih dari 0
                if (qty > 0)
                {
                    // Buat Panel untuk setiap item keranjang
                    RoundedPanel itemKeranjangPanel = new RoundedPanel();
                    itemKeranjangPanel.CornerRadius = 10;
                    itemKeranjangPanel.BorderColor = ColorTranslator.FromHtml("#e8e3cf");
                    itemKeranjangPanel.BorderThickness = 1;
                    // Lebar panel item: Pastikan cukup untuk semua kontrol di dalamnya
                    // Sesuaikan 280 ini dengan lebar flowPanelKeranjangHostItems Anda dikurangi sedikit padding.
                    itemKeranjangPanel.Size = new Size(flowPanelKeranjangHostItems.ClientSize.Width - 15, 100);
                    itemKeranjangPanel.BorderStyle = BorderStyle.None;
                    itemKeranjangPanel.Margin = new Padding(5);
                    itemKeranjangPanel.BackColor = ColorTranslator.FromHtml("#FFF8EA");

                    // --- Tambahkan Kontrol ke itemKeranjangPanel ---

                    // Gambar Produk (PictureBox)
                    PictureBox itemPictureBox = new PictureBox(); // Variabel dideklarasikan di sini
                    itemPictureBox.Size = new Size(80, 80);
                    itemPictureBox.Location = new Point(5, 5); // Posisi relatif dalam Panel
                    itemPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    itemPictureBox.BackColor = Color.Transparent;
                    string imageBasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
                    string fullImagePath = Path.Combine(imageBasePath, item.GambarPath);
                    if (File.Exists(fullImagePath))
                    {
                        try { itemPictureBox.Image = Image.FromFile(fullImagePath); }
                        catch { itemPictureBox.Image = new Bitmap(1, 1); } // Fallback jika gambar error
                    }
                    else { itemPictureBox.Image = new Bitmap(1, 1); } // Fallback jika gambar tidak ditemukan
                    itemKeranjangPanel.Controls.Add(itemPictureBox);

                    // Label Nama Produk
                    Label lblNamaProdukKeranjang = new Label(); // Variabel dideklarasikan di sini
                    lblNamaProdukKeranjang.Location = new Point(itemPictureBox.Right + 10, 5); // Sesuaikan X dan Y
                    lblNamaProdukKeranjang.AutoSize = false;
                    // Lebar ini harus memperhitungkan PictureBox, QuantityBox, dan Tombol Hapus
                    // (itemKeranjangPanel.Width - itemPictureBox.Width - keranjangQtyBox.Width - btnHapus.Width - padding)
                    lblNamaProdukKeranjang.Size = new Size(itemKeranjangPanel.Width - itemPictureBox.Width - 120, 20); // Sesuaikan lebar
                    lblNamaProdukKeranjang.Text = item.NamaBrownies;
                    lblNamaProdukKeranjang.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Contoh font
                    lblNamaProdukKeranjang.MaximumSize = new Size(lblNamaProdukKeranjang.Width, 0); // Agar bisa wrap teks
                    lblNamaProdukKeranjang.AutoEllipsis = true; // Tambahkan elipsis jika teks terlalu panjang
                    itemKeranjangPanel.Controls.Add(lblNamaProdukKeranjang);


                    // Label Harga Per Item (Harga total untuk kuantitas item ini)
                    Label lblHargaItem = new Label(); // Variabel dideklarasikan di sini
                    lblHargaItem.Text = $"Rp. {item.HargaBrownies * qty:N0}";
                    lblHargaItem.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    lblHargaItem.AutoSize = true;
                    // Posisikan ke kanan atas
                    lblHargaItem.Location = new Point(itemKeranjangPanel.Width - lblHargaItem.PreferredWidth - 20, 5); // Posisikan di kanan atas
                    lblHargaItem.Anchor = AnchorStyles.Top | AnchorStyles.Right; // Menempel kanan atas
                    itemKeranjangPanel.Controls.Add(lblHargaItem);

                    // QuantityBox (tombol -, 1, +)
                    QuantityBox keranjangQtyBox = new QuantityBox(); // Variabel dideklarasikan di sini
                    keranjangQtyBox.Minimum = 0;
                    keranjangQtyBox.Maximum = 200;
                    keranjangQtyBox.Value = qty;
                    // Posisikan QuantityBox relatif terhadap PictureBox dan Nama
                    keranjangQtyBox.Location = new Point(itemPictureBox.Right + 10, lblNamaProdukKeranjang.Bottom + 30);
                    keranjangQtyBox.Size = new Size(100, 25);
                    keranjangQtyBox.Tag = item.IdBrownies; // Simpan ID produk sebagai Tag

                    // Event ValueChanged untuk QuantityBox di SIDEBAR KERANJANG
                    keranjangQtyBox.ValueChanged += (s, ev) =>
                    {
                        QuantityBox senderQtyBox = s as QuantityBox;
                        int changedId = (int)senderQtyBox.Tag;
                        int changedQty = senderQtyBox.Value;

                        // Update data _quantityKeranjang dan _keranjangItems
                        if (changedQty > 0)
                        {
                            _quantityKeranjang[changedId] = changedQty;
                            // Pastikan item ada di _keranjangItems jika baru ditambahkan dari sidebar (jarang)
                            if (!_keranjangItems.Any(b => b.IdBrownies == changedId))
                            {
                                var addedBrownies = _dbcontext.Brownies.FirstOrDefault(b => b.IdBrownies == changedId);
                                if (addedBrownies != null) _keranjangItems.Add(addedBrownies);
                            }
                        }
                        else // Kuantitas menjadi 0, hapus item
                        {
                            _keranjangItems.RemoveAll(b => b.IdBrownies == changedId);
                            _quantityKeranjang.Remove(changedId);
                        }

                        // PENTING: Update QuantityBox di PRODUK LAYOUT PANEL (sisi kiri) juga!
                        if (_quantityControls.ContainsKey(changedId))
                        {
                            _quantityControls[changedId].Value = changedQty;
                        }

                        // Refresh seluruh sidebar keranjang
                        UpdateKeranjangSideBar();
                    };
                    // menambahkan komponen" yang sudah fix tadi ke rounded panel yang sudah dibuat
                    itemKeranjangPanel.Controls.Add(keranjangQtyBox);

                    // Tombol Hapus (ikon tempat sampah)
                    Button btnHapus = new Button(); // Variabel dideklarasikan di sini
                    string trashIconPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "trash_icon.png");
                    if (File.Exists(trashIconPath))
                    {
                        btnHapus.BackgroundImage = Image.FromFile(trashIconPath);
                    }
                    else
                    {
                        // Fallback jika ikon tidak ditemukan
                        Console.WriteLine($"Trash icon not found: {trashIconPath}");
                    } 
                    btnHapus.BackgroundImageLayout = ImageLayout.Zoom;
                    btnHapus.Size = new Size(24, 24);
                    // Posisikan di kanan bawah itemKeranjangPanel
                    btnHapus.Location = new Point(itemKeranjangPanel.Width - btnHapus.Width - 10, keranjangQtyBox.Bottom + 10);
                    btnHapus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right; // Tempel ke kanan bawah
                    btnHapus.FlatStyle = FlatStyle.Flat;
                    btnHapus.FlatAppearance.BorderSize = 0;
                    btnHapus.BackColor = Color.Transparent;
                    btnHapus.Cursor = Cursors.Hand;
                    btnHapus.Tag = item.IdBrownies; // Simpan ID produk

                    // Event Click untuk Tombol Hapus
                    btnHapus.Click += (s, ev) =>
                    {
                        int idProdukHapus = (int)((Button)s).Tag;

                        // Hapus dari data keranjang statis
                        _keranjangItems.RemoveAll(b => b.IdBrownies == idProdukHapus);
                        _quantityKeranjang.Remove(idProdukHapus);

                        // PENTING: Reset QuantityBox di PRODUK LAYOUT PANEL (sisi kiri) menjadi 0
                        if (_quantityControls.ContainsKey(idProdukHapus))
                        {
                            _quantityControls[idProdukHapus].Value = 0;
                        }

                        // Refresh seluruh sidebar keranjang
                        UpdateKeranjangSideBar();
                    };
                    itemKeranjangPanel.Controls.Add(btnHapus);

                    // Tambahkan panel item ke FlowLayoutPanel di sidebar
                    flowPanelKeranjangHostItems.Controls.Add(itemKeranjangPanel);

                    // Hitung subtotal
                    subtotal += (item.HargaBrownies * qty);
                }
            }
            // Akhir Langkah 11


            // Hitung dan Perbarui Label Ringkasan
            decimal pajak = subtotal * pajakrate;
            decimal total = subtotal + pajak + ongkir;

            UpdateKeranjangSummaryLabels(subtotal, pajak, ongkir, total);
        }
        private void UpdateKeranjangSummaryLabels(decimal subtotal, decimal pajak, decimal ongkosKirim, decimal total)
        {
            // Pastikan nama-nama label ini sesuai dengan yang Anda buat di Designer.cs
            // dan berada di pnlSummaryCost dan pnlTotal
            lblSubTotalValue.Text = $"Rp. {subtotal:N0}";
            lblPajakValue.Text = $"Rp. {pajak:N0}";
            lblOngkirValue.Text = $"Rp. {ongkosKirim:N0}";
            lblTotalValue.Text = $"Rp. {total:N0}";
        }
        private void ShowProductDetail(Browny selectedBrownies)
        {
            Form detailForm = new Form();
            detailForm.Text = "Detail Produk: " + selectedBrownies.NamaBrownies;
            detailForm.Size = new Size(400, 550);
            detailForm.StartPosition = FormStartPosition.CenterScreen;

            PictureBox detailPictureBox = new PictureBox();
            detailPictureBox.Size = new Size(300, 250);
            detailPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            detailPictureBox.Location = new Point(50, 20);

            string imageBasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            string fullImagePath = Path.Combine(imageBasePath, selectedBrownies.GambarPath);
            if (File.Exists(fullImagePath))
            {
                try
                {
                    detailPictureBox.Image = Image.FromFile(fullImagePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Gagal memuat gambar detail dari {fullImagePath}: {ex.Message}");
                    detailPictureBox.Image = new Bitmap(1, 1);
                }
            }
            else
            {
                Console.WriteLine($"File gambar detail tidak ditemukan: {fullImagePath}");
                detailPictureBox.Image = new Bitmap(1, 1);
            }

            Label lblDetailNama = new Label();
            lblDetailNama.Text = "Nama: " + selectedBrownies.NamaBrownies;
            lblDetailNama.Location = new Point(50, 280);
            lblDetailNama.AutoSize = true;
            lblDetailNama.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            Label lblDetailHarga = new Label();
            lblDetailHarga.Text = $"Harga: Rp. {selectedBrownies.HargaBrownies:N0}";
            lblDetailHarga.Location = new Point(50, 310);
            lblDetailHarga.AutoSize = true;
            lblDetailHarga.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            Label lblDetailDeskripsi = new Label();
            lblDetailDeskripsi.Text = "Deskripsi: " + selectedBrownies.Deskripsi;
            lblDetailDeskripsi.Location = new Point(50, 340);
            lblDetailDeskripsi.MaximumSize = new Size(300, 0);
            lblDetailDeskripsi.AutoSize = true;
            lblDetailDeskripsi.Font = new Font("Segoe UI", 9, FontStyle.Italic);

            detailForm.Controls.Add(detailPictureBox);
            detailForm.Controls.Add(lblDetailNama);
            detailForm.Controls.Add(lblDetailHarga);
            detailForm.Controls.Add(lblDetailDeskripsi);

            detailForm.ShowDialog();
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
            keranjang.KeranjangItems = _keranjangItems;
            keranjang.QuantityKeranjang = _quantityKeranjang;
            keranjang.ProdukQuantityControls = _quantityControls;

            // Penting: Langganan event CartSummaryUpdated dari UC_keranjang ke MainForm
            // Ini harus dilakukan di MainForm saat UC_keranjang di-host.
            // Misalnya, di MainForm:
            // keranjang.CartSummaryUpdated += this.UpdateMainFormSummaryLabels; // Buat metode ini di MainForm

            keranjang.LoadKeranjangDataAndDisplay();

            // Sekarang, ketika berpindah ke UC_keranjang, kita ingin sidebar detail TIDAK muncul
            // asumsikan parameter kedua NavigationEventArgs adalah RequireSideBar (navigasi utama)
            // dan parameter ketiga adalah RequireDetail (sidebar keranjang/summary)
            NavigateToUserControlRequested?.Invoke(this, new NavigationEventArgs(keranjang, false, false)); 
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

            NavigateToUserControlRequested?.Invoke(this, new(homePage,false,false));
        }
    }
}
