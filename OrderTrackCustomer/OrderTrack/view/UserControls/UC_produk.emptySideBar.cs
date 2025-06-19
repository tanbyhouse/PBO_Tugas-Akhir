using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTrack.view.UserControls
{
    partial class UC_produk
    {
        private void showEmptyPanel()
        {
            Label lblPesananKosong = new Label();
            lblPesananKosong.AutoSize = true;
            lblPesananKosong.BackColor = Color.FromArgb(232, 227, 207); // Latar belakang krem muda (sama dengan pnlKeranjangHost)
            lblPesananKosong.FlatStyle = FlatStyle.Flat;
            lblPesananKosong.Font = new Font("Microsoft Sans Serif", 13F);
            lblPesananKosong.Location = new Point(10, 50); // Posisi di dalam sel mainTableLayoutPanel
            lblPesananKosong.Name = "labelPesananSaya";
            lblPesananKosong.Size = new Size(154, 26);
            lblPesananKosong.TabIndex = 0;
            lblPesananKosong.Text = "Pesanannya Masih\nKosong Nih\n😔😔😔";
            lblPesananKosong.TextAlign = ContentAlignment.MiddleCenter; // Penataan teks

            Panel pnlKosong = new Panel();
            pnlKosong.BackColor = Color.Transparent;
            pnlKosong.Size = new Size(226, 264);
            pnlKosong.Controls.Add(lblPesananKosong);

            flowPanelKeranjangHostItems.AutoScroll = false;
            flowPanelKeranjangHostItems.Controls.Add(pnlKosong);
            UpdateKeranjangSummaryLabels(0, 0, 0, 0);
        }
    }
}
