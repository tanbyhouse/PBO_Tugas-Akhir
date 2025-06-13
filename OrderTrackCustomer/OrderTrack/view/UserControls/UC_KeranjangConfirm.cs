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
    public partial class UC_KeranjangConfirm : UserControl
    {
        public EventHandler<NavigationEventArgs> NavigateToUserControlRequested;
        public UC_KeranjangConfirm()
        {
            InitializeComponent();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            UC_confirmName uC_ConfirmName = new UC_confirmName();

            NavigateToUserControlRequested?.Invoke(this, new NavigationEventArgs(uC_ConfirmName,false, true, false));
        }
    }
}
