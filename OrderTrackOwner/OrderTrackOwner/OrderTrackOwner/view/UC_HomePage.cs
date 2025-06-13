using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderTrackOwner.utils;

namespace OrderTrackOwner.view
{
    public partial class UC_HomePage : UserControl
    {
        public event EventHandler<NavigationEventArgs> NavigateTouserControlRequested;
        public UC_HomePage()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            UC_DaftarMenu uC_DaftarMenu = new UC_DaftarMenu();

            NavigateTouserControlRequested?.Invoke(this, new(uC_DaftarMenu));
        }

        private void btnPesanan_Click(object sender, EventArgs e)
        {
            UC_DaftarPesanan uC_DaftarPesanan = new UC_DaftarPesanan();

            NavigateTouserControlRequested?.Invoke(this, new(uC_DaftarPesanan));
        }
    }
}
