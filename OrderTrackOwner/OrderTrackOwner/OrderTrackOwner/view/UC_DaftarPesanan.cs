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
    public partial class UC_DaftarPesanan : UserControl
    {
        public event EventHandler<NavigateEventArgs> NavigateTouserControlRequested;
        public UC_DaftarPesanan()
        {
            InitializeComponent();
        }
    }
}
