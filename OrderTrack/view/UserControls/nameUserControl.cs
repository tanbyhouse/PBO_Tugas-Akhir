using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderTrack.view.UserControls
{
    public partial class nameUserControl : UserControl
    {
        public EventHandler<UserControl> NavigateTouserControlRequested;
        public nameUserControl()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePageUserControl homePage = new HomePageUserControl();

            NavigateTouserControlRequested?.Invoke(this, homePage);
        }

        private void btnAlamat_Click(object sender, EventArgs e)
        {
            alamatUserControl alamatUserControl = new alamatUserControl();
            NavigateTouserControlRequested?.Invoke(this, alamatUserControl);
        }
    }
}
