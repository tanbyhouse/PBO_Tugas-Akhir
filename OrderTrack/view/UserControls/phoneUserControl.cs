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
    public partial class phoneUserControl : UserControl
    {
        public EventHandler<NavigationEventArgs> NavigateToUserControlRequested;
        public phoneUserControl()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            alamatUserControl alamatUserControl = new alamatUserControl();
            NavigateToUserControlRequested?.Invoke(this, new(alamatUserControl, false));
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            UC_produk listProduk = new UC_produk();
            NavigateToUserControlRequested?.Invoke(this, new(listProduk, false, false));
        }
    }
}
