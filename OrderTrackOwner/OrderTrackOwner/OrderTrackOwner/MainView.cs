using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderTrackOwner.utils;
using OrderTrackOwner.view;

namespace OrderTrackOwner
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
            UC_HomePage HomePage= new UC_HomePage();
            OnNavigateToUserControlRequested(this, new NavigationEventArgs(HomePage));
        }
        public void ShowUserControl(UserControl newControl, bool isOverlay = false)
        {
            if (mainPanel == null)
            {
                MessageBox.Show("Error: pnlContent is not initialized.");
                return;
            }
            if (mainPanel.Controls.Count > 0)
            {
                mainPanel.Controls[0].Enabled = false;
            }

            // Tambahkan kontrol baru
            newControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(newControl);
            newControl.BringToFront(); // Pastikan kontrol baru di depan
        }
        public void OnNavigateToUserControlRequested(object sender, NavigationEventArgs e)
        {
            if (e.userControl is UC_HomePage homePage)
            {
                homePage.NavigateTouserControlRequested += OnNavigateToUserControlRequested;
            }

            ShowUserControl(e.userControl);
        }
    }
}
