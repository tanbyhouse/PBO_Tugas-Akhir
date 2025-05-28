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
    public partial class UC_produk : UserControl
    {
        public EventHandler<NavigationEventArgs> NavigateToUserControlRequested;
        public UC_produk()
        {
            InitializeComponent();
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            UC_keranjang keranjang = new UC_keranjang();

            NavigateToUserControlRequested?.Invoke(this, new NavigationEventArgs(keranjang, true, true));
        }
        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesanan telah masuk ke keranjang silahkan cek keranjang anda", "Pesanan Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
