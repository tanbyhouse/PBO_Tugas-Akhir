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
    public partial class nameUserControl : UserControl
    {
        public EventHandler<NavigationEventArgs> NavigateTouserControlRequested;
        public nameUserControl()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePageUserControl homePage = new HomePageUserControl();

            NavigateTouserControlRequested?.Invoke(this, new(homePage, false));
        }

        private void btnAlamat_Click(object sender, EventArgs e)
        {
            alamatUserControl alamatUserControl = new alamatUserControl();
            NavigateTouserControlRequested?.Invoke(this, new(alamatUserControl, false, false));
        }
    }
}
