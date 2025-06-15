using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderTrack.view.UserControls; // Penting: Mengimpor namespace untuk UserControl Anda
using OrderTrack.utils; // Penting: Mengimpor namespace untuk NavigationEventArgs

namespace OrderTrack.view // Namespace yang sama dengan MainView.Designer.cs
{
    public partial class MainView : Form // Keyword 'partial' dan pewarisan dari Form
    {
        // -----------------------------------------------------------------------
        // Bagian Konstruktor
        // -----------------------------------------------------------------------
        public MainView()
        {
            InitializeComponent(); // Wajib dipanggil!
            ShowInitialUserControl(); // Memulai aplikasi dengan UserControl awal
        }

        // -----------------------------------------------------------------------
        // Metode Inisialisasi UserControl Awal
        // -----------------------------------------------------------------------
        private void ShowInitialUserControl()
        {
            HomePageUserControl HomePage = new HomePageUserControl(); // Membuat instance HomePageUserControl
            // Memanggil metode untuk menavigasi ke HomePageUserControl
            // Parameter: sender (this), NavigationEventArgs (HomePage, tidak overlay, tidak require detail, tidak from popup)
            OnNavigateToUserControlRequested(this, new NavigationEventArgs(HomePage, false, false));
        }

        // -----------------------------------------------------------------------
        // Metode Publik untuk Menampilkan UserControl
        // -----------------------------------------------------------------------
        public void ShowUserControl(UserControl newControl, bool isOverlay = false)
        {
            // Pengecekan keamanan: Pastikan pnlContent sudah diinisialisasi
            if (pnlContent == null)
            {
                MessageBox.Show("Error: pnlContent is not initialized.");
                return; // Keluar dari metode jika pnlContent null
            }
            // Nonaktifkan UserControl yang ada di belakang (jika ada)
            if (pnlContent.Controls.Count > 0)
            {
                pnlContent.Controls[0].Enabled = false; // Asumsi kontrol utama selalu di index 0
            }
            // Menambahkan kontrol baru ke pnlContent
            newControl.Dock = DockStyle.Fill; // Mengisi seluruh area pnlContent
            pnlContent.Controls.Add(newControl); // Menambahkan kontrol baru
            newControl.BringToFront(); // Memastikan kontrol baru tampil di paling depan
        }
        // -----------------------------------------------------------------------
        // Metode Handler Event Navigasi
        // -----------------------------------------------------------------------
        private void OnNavigateToUserControlRequested(object sender, NavigationEventArgs e)
        {
            pnlSummaryKeranjang.Visible = e.RequireSideBar;

            if (e.userControl is HomePageUserControl homepageUC)
            {
                // Cast (as) berhasil, sekarang kita bisa mengakses properti atau metode spesifik homepageUC.
                homepageUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
                // Ini memastikan bahwa ketika HomePageUserControl ingin menavigasi, ia akan memanggil kembali
                // metode ini di MainView.
            }
            else if (e.userControl is UC_confirmName nameUC) // Asumsi ini adalah UserControl untuk input nama
            {
                nameUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            else if (e.userControl is UC_confirmAddress addressUC) // Asumsi ini adalah UserControl untuk input alamat
            {
                addressUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            else if (e.userControl is UC_confirmPhone phoneUC) // Asumsi ini adalah UserControl untuk input telepon
            {
                phoneUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            else if (e.userControl is UC_produk UCproduk) // UserControl untuk daftar produk
            {
                UCproduk.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            else if (e.userControl is UC_keranjang keranjangUC) // UserControl untuk detail keranjang
            {
                keranjangUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
                // Di sini Anda juga bisa menambahkan handler untuk event update keranjang dari UC_keranjang
                // keranjangUC.CartSummaryUpdated += (s, args) => UpdateCartSummary(args); // Contoh
            }
            else if (e.userControl is UC_confirmName confirmnameUC) // UserControl untuk konfirmasi nama
            {
                confirmnameUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            else if (e.userControl is UC_confirmAddress confirmAddressUC) // UserControl untuk konfirmasi alamat
            {
                confirmAddressUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            else if (e.userControl is UC_confirmPhone confirmPhoneUC) // UserControl untuk konfirmasi telepon
            {
                confirmPhoneUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }

            // 3. Menampilkan UserControl yang diminta
            // Setelah berlangganan event (jika perlu), panggil ShowUserControl untuk benar-benar menampilkan kontrol.
            ShowUserControl(e.userControl);
        }
    }
}