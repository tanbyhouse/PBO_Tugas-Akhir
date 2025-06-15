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
    public partial class UC_confirmPhone : UserControl
    {
        public EventHandler<NavigationEventArgs> NavigateToUserControlRequested;
        public UC_confirmPhone()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UC_confirmAddress uC_ConfirmAddress = new UC_confirmAddress();
            NavigateToUserControlRequested?.Invoke(this, new NavigationEventArgs(uC_ConfirmAddress, false, true));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            HomePageUserControl home = new HomePageUserControl();
            NavigateToUserControlRequested?.Invoke(this, new NavigationEventArgs(home, false, false));
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            HomePageUserControl home = new HomePageUserControl();
            NavigateToUserControlRequested?.Invoke(this, new NavigationEventArgs(home, false, false));
        }
    }
}
