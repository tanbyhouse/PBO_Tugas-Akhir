using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; // Penting untuk ColorTranslator
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Penting untuk UserControl
using OrderTrack.utils; // Penting untuk NavigationEventArgs
using OrderTrack.view.UserControls; // Mengimpor namespace untuk UC_produk dan UC_keranjang

namespace OrderTrack.view.UserControls
{
    public partial class HomePageUserControl : UserControl
    {
        // Deklarasi Event: Memungkinkan MainView untuk tahu kapan HomePage meminta navigasi
        public event EventHandler<NavigationEventArgs> NavigateToUserControlRequested;

        public HomePageUserControl()
        {
            InitializeComponent();
            // Mengatur warna latar belakang tombol
            btnBuatPesanan.BackColor = ColorTranslator.FromHtml("#FEF8DF");
            btnPesanan.BackColor = ColorTranslator.FromHtml("#D2B48C");
            btnKeranjang.BackColor = ColorTranslator.FromHtml("#D2B48C");

            // Pastikan event handler terhubung ke tombol Anda di Designer.cs atau secara manual di sini
            // Contoh: btnBuatPesanan.Click += btnBuatPesanan_Click;
            // Contoh: btnKeranjang.Click += btnKeranjang_Click;
            // Contoh: btnPesanan.Click += btnPesanan_Click;
        }

        // Metode pemicu event NavigateToUserControlRequested
        protected virtual void OnNavigateToUserControlRequested(NavigationEventArgs e)
        {
            NavigateToUserControlRequested?.Invoke(this, e);
        }

        // Event handler untuk tombol "Buat Pesanan" (menuju halaman produk)
        private void btnBuatPesanan_Click(object sender, EventArgs e)
        {
            UC_produk uC_Produk = new UC_produk();
            // Navigasi ke UC_produk. Parameter RequireDetail (true) tidak akan berpengaruh pada sidebar MainView.
            // Namun, ini bisa digunakan jika UC_produk sendiri perlu tahu untuk menampilkan sidebarnya.
            OnNavigateToUserControlRequested(new NavigationEventArgs(uC_Produk, false, true));
        }

        // Event handler untuk tombol "Keranjang" (menuju halaman keranjang)
        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            UC_keranjang uC_Keranjang = new UC_keranjang();
            // Navigasi ke UC_keranjang. Parameter RequireDetail (true) tidak akan berpengaruh pada sidebar MainView.
            OnNavigateToUserControlRequested(new NavigationEventArgs(uC_Keranjang, false, true));
        }

        // Contoh: Event handler untuk tombol "Pesanan" (Jika ada)
        private void btnPesanan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Halaman Pesanan belum diimplementasikan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
