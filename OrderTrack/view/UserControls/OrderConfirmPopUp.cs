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
    public partial class OrderConfirmPopUp : UserControl
    {
        public event EventHandler PopupClosed; // Event untuk menandakan popup ditutup
        public EventHandler<NavigationEventArgs> NavigateToUserControlRequested;
        public OrderConfirmPopUp()
        {
            InitializeComponent();

            pnlMessageBox.Location = new Point(
                (pnlOverlayBg.Width - pnlMessageBox.Width) / 2,
                (pnlOverlayBg.Height - pnlMessageBox.Height) / 2
            );
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            PopupClosed?.Invoke(this, EventArgs.Empty); // Panggil event ini saat tombol OK 

            HomePageUserControl userControl = new HomePageUserControl();
            NavigateToUserControlRequested?.Invoke(this, new NavigationEventArgs(userControl, false, false));
        }

        private void btnOkay_Click_1(object sender, EventArgs e)
        {
            HomePageUserControl userControl = new HomePageUserControl();
            NavigateToUserControlRequested?.Invoke(this, new NavigationEventArgs(userControl, false, false));
        }
    }
}
