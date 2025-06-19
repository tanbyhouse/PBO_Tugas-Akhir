using OrderTrack.view.UserControls; // Mengimpor namespace untuk UserControl buatan sendiri
using OrderTrack.utils; // Mengimpor namespace untuk NavigationEventArgs juga buatan sendiri
using OrderTrack.view.UserControls;

namespace OrderTrack.view // Namespace yang sama dengan MainView.Designer.cs
{
    public partial class MainView : Form // Keyword 'partial' dan pewarisan dari Form
    {
        private UserControl _currentActiveUserControl;
        UC_produk uC_Produk;
        // -----------------------------------------------------------------------
        // Bagian Konstruktor
        // -----------------------------------------------------------------------
        public MainView()
        {
            InitializeComponent(); // Wajib dipanggil!
            uC_Produk = new UC_produk();
            UC_produk.ActiveProdukInstance = uC_Produk;
            uC_Produk.CartSummaryUpdated += UcProduk_CartSummaryUpdated;
            ShowInitialUserControl(); // Memulai aplikasi dengan UserControl awal
        }
        // -----------------------------------------------------------------------
        // Metode Inisialisasi UserControl Awal
        // -----------------------------------------------------------------------
        private void ShowInitialUserControl()
        {
            HomePageUserControl HomePage = new HomePageUserControl(); // Membuat instance HomePageUserControl
            // Memanggil metode untuk menavigasi ke HomePageUserControl
            // Parameter: sender (this), NavigationEventArgs (HomePage, tidak require sidebar)
            MainNavigateToUserControlRequested(this, new NavigationEventArgs(HomePage, false));
        }   
        // -----------------------------------------------------------------------
        // Metode Publik untuk Menampilkan UserControl
        // -----------------------------------------------------------------------
        public void ShowUserControl(UserControl newControl, bool sidebar)
        {
            // Hapus UserControl sebelumnya dari panel host
            if (_currentActiveUserControl != null)
            {
               this.pnlHeader.Controls.Remove(_currentActiveUserControl);
            }
            // Nonaktifkan UserControl yang ada di belakang (jika ada)
            if (_currentActiveUserControl != null && _currentActiveUserControl is INavigableUserControl oldNavigableUserControl)
            {
                // digunakan untuk menghindari memory leak dengan meng-unsubscribe event yang lama
                oldNavigableUserControl.NavigateToUserControlRequested -= MainNavigateToUserControlRequested;
            }             
            // Menambahkan user control baru ke pnlHeader
            newControl.Dock = DockStyle.Fill; // Mengisi seluruh area pnlHeader
            pnlHeader.Controls.Add(newControl); // Menambahkan kontrol baru
            _currentActiveUserControl = newControl; // mereferensikan objek baru berupa newcontrol sebagai parameter method
            if (sidebar == true)
            {
                pnlSummaryKeranjang.Dock = DockStyle.Right;
                newControl.Controls.Add(pnlSummaryKeranjang);
            }
        }
        // -----------------------------------------------------------------------
        // Metode Handler Event Navigasi
        // -----------------------------------------------------------------------
        private void MainNavigateToUserControlRequested(object sender, NavigationEventArgs e)
        {
            pnlSummaryKeranjang.Visible = e.RequireSideBar;

            if (e.userControl is INavigableUserControl navigableUser)
            {
                // Cast (as) berhasil, sekarang kita bisa mengakses properti atau metode spesifik homepageUC.
                navigableUser.NavigateToUserControlRequested += MainNavigateToUserControlRequested;
                // Ini memastikan bahwa ketika HomePageUserControl ingin menavigasi, ia akan memanggil kembali
                // metode ini di MainView.
            }
            // 3. Menampilkan UserControl yang diminta
            // Setelah berlangganan event (jika perlu), panggil ShowUserControl untuk benar-benar menampilkan kontrol.
            ShowUserControl(e.userControl, e.RequireSideBar);
        }
        private void UcProduk_CartSummaryUpdated(object sender, CartSummaryUpdateEventArgs e)
        {
            // Update label-label di pnlSummaryKeranjang (sidebar MainView)
            // Pastikan Anda sudah mendeklarasikan dan menginisialisasi label-label ini
            // agar tidak null.
            if (lblSubTotalValue != null) lblSubTotalValue.Text = $"Rp. {e.Subtotal:N0}";
            if (lblPajakValue!= null) lblPajakValue.Text = $"Rp. {e.Tax:N0}";
            if (lblOngkirValue != null) lblOngkirValue.Text = $"Rp. {e.Shipping:N0}";
            if (lblTotalValue != null) lblTotalValue.Text = $"Rp. {e.Total:N0}";
        }
    }
}