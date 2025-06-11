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
    public partial class HomePageUserControl : UserControl
    {
        public event EventHandler<NavigationEventArgs> NavigateTouserControlRequested;
        public HomePageUserControl()
        {
            InitializeComponent();

            btnBuatPesanan.BackColor = ColorTranslator.FromHtml("#FEF8DF");
            btnPesanan.BackColor = ColorTranslator.FromHtml("#D2B48C");
            btnKeranjang.BackColor = ColorTranslator.FromHtml("#D2B48C");
        }

        private void btnBuatPesanan_Click(object sender, EventArgs e)
        {
            //nameUserControl pageNama = new nameUserControl();
            //NavigateTouserControlRequested?.Invoke(this, new(pageNama, false, false));
            UC_produk uC_Produk = new UC_produk();
            NavigateTouserControlRequested?.Invoke(this, new NavigationEventArgs(uC_Produk, false, false, false));
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            UC_keranjang uC_Keranjang = new UC_keranjang();

            NavigateTouserControlRequested?.Invoke(this, new(uC_Keranjang, true, true));
        }
    }
}
