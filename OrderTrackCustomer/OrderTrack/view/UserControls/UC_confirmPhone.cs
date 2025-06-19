using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using OrderTrack.utils;

namespace OrderTrack.view.UserControls
{
    public partial class UC_confirmPhone : BaseUserControl
    {
        public UC_confirmPhone()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UC_confirmAddress uC_ConfirmAddress = new UC_confirmAddress();
            OnNavigateToUserControlRequested(new NavigationEventArgs(uC_ConfirmAddress, true));
        }
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            HomePageUserControl home = new HomePageUserControl();
            OnNavigateToUserControlRequested(new NavigationEventArgs(home, false));
        }
    }
}
