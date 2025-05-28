using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderTrack.utils;

namespace OrderTrack.view.UserControls
{
    public partial class RegisterUserControl : UserControl
    {
        public event EventHandler<NavigationEventArgs> NavigateToUserControlRequested;
        public RegisterUserControl()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            HomePageUserControl homePageUserControl = new HomePageUserControl();

            NavigateToUserControlRequested?.Invoke(this, new NavigationEventArgs(homePageUserControl, false, false));
        }
    }
}
