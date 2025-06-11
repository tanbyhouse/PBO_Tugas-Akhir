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
    public partial class UC_confirmAddress : UserControl
    {
        public EventHandler<NavigationEventArgs> NavigateToUserControlRequested;
        public UC_confirmAddress()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UC_confirmName confirmName = new UC_confirmName();
            NavigateToUserControlRequested?.Invoke(this, new NavigationEventArgs(confirmName, false, true));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            UC_confirmPhone uC_ConfirmPhone = new UC_confirmPhone();
            NavigateToUserControlRequested?.Invoke(this, new NavigationEventArgs(uC_ConfirmPhone, false, true));
        }
    }
}
