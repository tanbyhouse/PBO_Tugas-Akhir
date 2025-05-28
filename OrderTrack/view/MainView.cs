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
            sideBar.Visible = false;
            detail_pesanan.Visible = false;
            registerUserControl.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            ShowUserControl(registerUserControl);
        }
        public void ShowUserControl(UserControl newControl)
        {
            if (pnlContent == null)
            {
                MessageBox.Show("Panel content is not initialized.");
                return;
            }

            if (pnlContent.Controls.Count > 0)
            {
                pnlContent.Controls[0].Dispose();
                pnlContent.Controls.Clear();
            }

            newControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(newControl);
            newControl.BringToFront();
        }
        private void OnNavigateToUserControlRequested(object sender, NavigationEventArgs e)
        {
            sideBar.Visible = e.RequireSideBar;
            detail_pesanan.Visible = e.RequireDetail;
            if (e.userControl is HomePageUserControl homepageUC)
            {
                homepageUC.NavigateTouserControlRequested += OnNavigateToUserControlRequested;
            }
            if (e.userControl is RegisterUserControl registerUC)
            {
                registerUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            if (e.userControl is nameUserControl nameUC)
            {
                nameUC.NavigateTouserControlRequested += OnNavigateToUserControlRequested;
            }
            if (e.userControl is alamatUserControl addressUC)
            {
                addressUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            if (e.userControl is phoneUserControl phoneUC)
            {
                phoneUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            if (e.userControl is UC_produk UCproduk)
            {
                UCproduk.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            if (e.userControl is UC_keranjang keranjangUC)
            {
                keranjangUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            if (e.userControl is UC_confirmName confirmnameUC)
            {
                confirmnameUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            if (e.userControl is UC_confirmAddress confirmAddressUC)
            {
                confirmAddressUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            ShowUserControl(e.userControl);
        }
    }
}
