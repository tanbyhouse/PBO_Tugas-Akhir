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
    public partial class UC_confirmName : UserControl
    {
        public EventHandler<NavigationEventArgs> NavigateToUserControlRequested;
        public UC_confirmName()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UC_KeranjangConfirm keranjang = new UC_KeranjangConfirm();

            NavigateToUserControlRequested?.Invoke(this, new NavigationEventArgs(keranjang, true, true));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            UC_confirmAddress alamat = new UC_confirmAddress();
            NavigateToUserControlRequested?.Invoke(this, new NavigationEventArgs(alamat, false, false));
        }
    }
}
