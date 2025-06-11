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
    public partial class alamatUserControl : UserControl
    {
        public EventHandler<NavigationEventArgs> NavigateToUserControlRequested;
        public alamatUserControl()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            nameUserControl namePage = new nameUserControl();
            NavigateToUserControlRequested?.Invoke(this, new(namePage, false));
        }

        private void btnAlamat_Click(object sender, EventArgs e)
        {
            phoneUserControl phoneUserControl = new phoneUserControl();
            NavigateToUserControlRequested?.Invoke(this, new(phoneUserControl, false, false));
        }
    }
}
