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
        private void OnNavigateToUserControlRequested(object sender, UserControl requestedControl)
        {
            if (requestedControl is HomePageUserControl homepageUC)
            {
                homepageUC.NavigateTouserControlRequested += OnNavigateToUserControlRequested;
            }
            if (requestedControl is RegisterUserControl registerUC)
            {
                registerUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            if (requestedControl is nameUserControl nameUC)
            {
                nameUC.NavigateTouserControlRequested += OnNavigateToUserControlRequested;
            }
            if (requestedControl is alamatUserControl addressUC)
            {
                addressUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            if (requestedControl is phoneUserControl phoneUC)
            {
                phoneUC.NavigateToUserControlRequested += OnNavigateToUserControlRequested;
            }
            ShowUserControl(requestedControl);
        }
    }
}
