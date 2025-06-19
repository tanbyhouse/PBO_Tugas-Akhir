using OrderTrack.utils; // Penting untuk NavigationEventArgs

// menyesuaikan assembly dari path folder nya yakni OrderTrack/UserControls
namespace OrderTrack.view.UserControls
{
    // merupakan class partial dengan penerapan konsep OOP yakni inheritance ke BaseUserControl
    public partial class HomePageUserControl : BaseUserControl
    {
        // contructor class
        public HomePageUserControl()
        {
            // hasil method dari HomePageUserControl.Design tempat mengatur UI dari UC
            InitializeComponent();
        }
        // Event handler untuk tombol "Buat Pesanan" (menuju halaman produk)
        private void btnBuatPesanan_Click(object sender, EventArgs e)
        {
            // membuat instance baru dari class UC_produk
            UC_produk uC_Produk = new UC_produk();
            // Navigasi ke UC_produk
            OnNavigateToUserControlRequested(new NavigationEventArgs(uC_Produk, false));
        }

        // Event handler untuk tombol "Keranjang" (menuju halaman keranjang)
        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            // membuat instance baru dari class UC_keranjang
            UC_keranjang uC_Keranjang = new UC_keranjang();
            // Navigasi ke UC_keranjang
            uC_Keranjang.LoadKeranjangDataAndDisplay();
            OnNavigateToUserControlRequested(new NavigationEventArgs(uC_Keranjang, true));
        }
        
        // untuk masuk ke UC pesanan sebagai hasil akhir dari pesanan pembeli
        private void btnPesanan_Click_1(object sender, EventArgs e)
        {
            // membuat instance baru class UC_detailpesanan
            UC_detailPesanan uC_DetailPesanan = new UC_detailPesanan();
            // Navigasi ke UC_produk
            OnNavigateToUserControlRequested(new NavigationEventArgs(uC_DetailPesanan, false));
        }
    }
}
