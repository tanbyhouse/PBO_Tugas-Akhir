using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderTrack.view.UserControls;
using OrderTrack.utils;

namespace OrderTrack.view
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();

            ShowInitialUserControl();
        }
        private void ShowInitialUserControl()
        {
            RegisterUserControl registerUserControl = new RegisterUserControl();
            OnNavigateToUserControlRequested(this, new NavigationEventArgs(registerUserControl, false, false, false));
        }
        public void ShowUserControl(UserControl newControl, bool isOverlay = false)
        {
            if (pnlContent == null)
            {
                MessageBox.Show("Error: pnlContent is not initialized.");
                return;
            }

            if (!isOverlay) // Jika ini BUKAN overlay, hapus kontrol yang lama
            {
                // Ganti loop while dengan loop for yang lebih aman atau cukup hapus semua secara langsung
                // Cara paling aman untuk menghapus semua kontrol:
                while (pnlContent.Controls.Count > 0)
                {
                    // Ambil kontrol pertama, dispose, lalu hapus dari koleksi
                    Control controlToRemove = pnlContent.Controls[0];
                    pnlContent.Controls.RemoveAt(0);
                    controlToRemove.Dispose(); // Penting untuk melepaskan sumber daya
                }
            }
            else // Jika ini overlay
            {
                // Nonaktifkan UserControl di belakang overlay (jika ada)
                if (pnlContent.Controls.Count > 0)
                {
                    // Asumsi UserControl yang utama ada di index 0
                    pnlContent.Controls[0].Enabled = false;
                }

                // Hapus semua overlay yang mungkin sudah ada
                // Loop mundur agar penghapusan tidak mengganggu indeks iterasi
                for (int i = pnlContent.Controls.Count - 1; i >= 0; i--)
                {
                    // Hanya hapus jika itu adalah UserControl overlay (misal UC_OrderConfirmationPopup)
                    // ATAU TransparentPanel yang kamu gunakan sebagai container overlay
                    if (pnlContent.Controls[i] is OrderConfirmPopUp || pnlContent.Controls[i] is TransparentPanel)
                    {
                        Control controlToRemove = pnlContent.Controls[i];
                        pnlContent.Controls.RemoveAt(i);
                        controlToRemove.Dispose();
                    }
                }
            }

            // Tambahkan kontrol baru
            newControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(newControl);
            newControl.BringToFront(); // Pastikan kontrol baru di depan
        }
        private void OnNavigateToUserControlRequested(object sender, NavigationEventArgs e)
        {
            sideBar.Visible = e.RequireSideBar;
            detail_pesanan.Visible = e.RequireDetail;
            if (e.userControl is HomePageUserControl homepageUC)
            {
                homepageUC.NavigateTouserControlRequested += OnNavigateToUserControlRequested;
            }
            else if (e.userControl is RegisterUserControl registerUC)
            {
                registerUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            else if (e.userControl is nameUserControl nameUC)
            {
                nameUC.NavigateTouserControlRequested += OnNavigateToUserControlRequested;
            }
            else if (e.userControl is alamatUserControl addressUC)
            {
                addressUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            else if (e.userControl is phoneUserControl phoneUC)
            {
                phoneUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            else if (e.userControl is UC_produk UCproduk)
            {
                UCproduk.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            else if (e.userControl is UC_keranjang keranjangUC)
            {
                keranjangUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            else if (e.userControl is UC_confirmName confirmnameUC)
            {
                confirmnameUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            else if (e.userControl is UC_confirmAddress confirmAddressUC)
            {
                confirmAddressUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            else if (e.userControl is UC_confirmPhone confirmPhoneUC)
            {
                confirmPhoneUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            else if (e.userControl is OrderConfirmPopUp popupUC)
            {
                popupUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
                // PENTING: Tambahkan handler untuk event PopupClosed dari overlay
                popupUC.PopupClosed += (s, args) =>
                {
                    // Hapus overlay dari pnlContent
                    pnlContent.Controls.Remove(popupUC);
                    popupUC.Dispose();

                    // Aktifkan kembali UserControl di belakangnya (jika sebelumnya dinonaktifkan)
                    if (pnlContent.Controls.Count > 0)
                    {
                        // Asumsi UserControl utama ada di index 0
                        pnlContent.Controls[0].Enabled = true;
                    }
                };
            }
            ShowUserControl(e.userControl);
        }
    }
}
