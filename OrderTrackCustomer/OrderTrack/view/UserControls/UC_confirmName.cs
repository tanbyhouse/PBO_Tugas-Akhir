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
    public partial class UC_confirmName : BaseUserControl
    {
        public UC_confirmName()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UC_keranjang keranjang = new UC_keranjang();

            OnNavigateToUserControlRequested(new NavigationEventArgs(keranjang, true));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            UC_confirmAddress alamat = new UC_confirmAddress();
            OnNavigateToUserControlRequested(new NavigationEventArgs(alamat, true));
        }
    }
}
