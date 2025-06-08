namespace OrderTrack.view
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlContent = new Panel();
            sideBar = new Panel();
            phoneValue = new Label();
            addressValue = new Label();
            nameValue = new Label();
            detail_pesanan = new Panel();
            labelTotal = new Label();
            labelOngkir = new Label();
            labelPajak = new Label();
            labelSubTotal = new Label();
            labelDetailPesanan = new Label();
            sideBar.SuspendLayout();
            detail_pesanan.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(800, 450);
            pnlContent.TabIndex = 0;
            // 
            // sideBar
            // 
            sideBar.BackColor = SystemColors.ActiveCaptionText;
            sideBar.Controls.Add(phoneValue);
            sideBar.Controls.Add(addressValue);
            sideBar.Controls.Add(nameValue);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(199, 450);
            sideBar.TabIndex = 0;
            // 
            // phoneValue
            // 
            phoneValue.AutoSize = true;
            phoneValue.ForeColor = Color.White;
            phoneValue.Location = new Point(75, 227);
            phoneValue.Name = "phoneValue";
            phoneValue.Size = new Size(80, 20);
            phoneValue.TabIndex = 2;
            phoneValue.Text = "Nomor Hp";
            phoneValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addressValue
            // 
            addressValue.AutoSize = true;
            addressValue.ForeColor = Color.White;
            addressValue.Location = new Point(75, 175);
            addressValue.Name = "addressValue";
            addressValue.Size = new Size(57, 20);
            addressValue.TabIndex = 1;
            addressValue.Text = "Alamat";
            addressValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameValue
            // 
            nameValue.AutoSize = true;
            nameValue.ForeColor = Color.White;
            nameValue.Location = new Point(75, 125);
            nameValue.Name = "nameValue";
            nameValue.Size = new Size(49, 20);
            nameValue.TabIndex = 0;
            nameValue.Text = "Nama";
            nameValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // detail_pesanan
            // 
            detail_pesanan.BackColor = SystemColors.AppWorkspace;
            detail_pesanan.Controls.Add(labelTotal);
            detail_pesanan.Controls.Add(labelOngkir);
            detail_pesanan.Controls.Add(labelPajak);
            detail_pesanan.Controls.Add(labelSubTotal);
            detail_pesanan.Controls.Add(labelDetailPesanan);
            detail_pesanan.Dock = DockStyle.Right;
            detail_pesanan.Location = new Point(515, 0);
            detail_pesanan.Name = "detail_pesanan";
            detail_pesanan.Size = new Size(285, 450);
            detail_pesanan.TabIndex = 4;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.BackColor = Color.White;
            labelTotal.Location = new Point(19, 342);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(42, 20);
            labelTotal.TabIndex = 4;
            labelTotal.Text = "Total";
            // 
            // labelOngkir
            // 
            labelOngkir.AutoSize = true;
            labelOngkir.BackColor = Color.White;
            labelOngkir.Location = new Point(19, 149);
            labelOngkir.Name = "labelOngkir";
            labelOngkir.Size = new Size(98, 20);
            labelOngkir.TabIndex = 3;
            labelOngkir.Text = "Ongkos Kirim";
            // 
            // labelPajak
            // 
            labelPajak.AutoSize = true;
            labelPajak.BackColor = Color.White;
            labelPajak.Location = new Point(19, 112);
            labelPajak.Name = "labelPajak";
            labelPajak.Size = new Size(43, 20);
            labelPajak.TabIndex = 2;
            labelPajak.Text = "Pajak";
            // 
            // labelSubTotal
            // 
            labelSubTotal.AutoSize = true;
            labelSubTotal.BackColor = Color.White;
            labelSubTotal.Location = new Point(19, 75);
            labelSubTotal.Name = "labelSubTotal";
            labelSubTotal.Size = new Size(65, 20);
            labelSubTotal.TabIndex = 1;
            labelSubTotal.Text = "Subtotal";
            // 
            // labelDetailPesanan
            // 
            labelDetailPesanan.AutoSize = true;
            labelDetailPesanan.BackColor = Color.White;
            labelDetailPesanan.Location = new Point(78, 17);
            labelDetailPesanan.Name = "labelDetailPesanan";
            labelDetailPesanan.Size = new Size(106, 20);
            labelDetailPesanan.TabIndex = 0;
            labelDetailPesanan.Text = "Detail Pesanan";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(detail_pesanan);
            Controls.Add(sideBar);
            Controls.Add(pnlContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainView";
            Text = "MainView";
            sideBar.ResumeLayout(false);
            sideBar.PerformLayout();
            detail_pesanan.ResumeLayout(false);
            detail_pesanan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContent;
        private Panel sideBar;
        private Label nameValue;
        private Label phoneValue;
        private Label addressValue;
        private Panel detail_pesanan;
        private Label labelTotal;
        private Label labelOngkir;
        private Label labelPajak;
        private Label labelSubTotal;
        private Label labelDetailPesanan;
    }
}