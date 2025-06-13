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
    public partial class UC_keranjang : UserControl
    {
        public EventHandler<NavigationEventArgs> NavigateToUserControlRequested;
        public UC_keranjang()
        {
            InitializeComponent();
            LoadKeranjangItems();
        }
        private void LoadKeranjangItems()
        {
            var items = UC_produk.GetKeranjangItems();
            var quantities = UC_produk.GetQuantityKeranjang();
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            UC_confirmName uC_ConfirmName = new UC_confirmName();

            NavigateToUserControlRequested?.Invoke(this, new NavigationEventArgs(uC_ConfirmName, false, true));
        }
    }
}
