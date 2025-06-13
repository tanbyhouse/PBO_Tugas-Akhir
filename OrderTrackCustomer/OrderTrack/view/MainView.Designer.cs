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
            detail_pesanan = new Panel();
            labelTotal = new Label();
            labelOngkir = new Label();
            labelPajak = new Label();
            labelSubTotal = new Label();
            labelDetailPesanan = new Label();
            panel1 = new Panel();
            detail_pesanan.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Margin = new Padding(3, 2, 3, 2);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(700, 338);
            pnlContent.TabIndex = 0;
            // 
            // detail_pesanan
            // 
            detail_pesanan.BackColor = Color.FromArgb(250, 250, 250);
            detail_pesanan.Controls.Add(labelTotal);
            detail_pesanan.Controls.Add(labelOngkir);
            detail_pesanan.Controls.Add(labelPajak);
            detail_pesanan.Controls.Add(labelSubTotal);
            detail_pesanan.Controls.Add(labelDetailPesanan);
            detail_pesanan.Controls.Add(panel1);
            detail_pesanan.Dock = DockStyle.Right;
            detail_pesanan.Location = new Point(451, 0);
            detail_pesanan.Margin = new Padding(3, 2, 3, 2);
            detail_pesanan.Name = "detail_pesanan";
            detail_pesanan.Size = new Size(249, 338);
            detail_pesanan.TabIndex = 4;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.BackColor = Color.FromArgb(232, 227, 207);
            labelTotal.Font = new Font("Gilroy-Bold", 10F);
            labelTotal.Location = new Point(14, 299);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(40, 18);
            labelTotal.TabIndex = 4;
            labelTotal.Text = "Total";
            // 
            // labelOngkir
            // 
            labelOngkir.AutoSize = true;
            labelOngkir.BackColor = Color.Transparent;
            labelOngkir.Font = new Font("Gilroy-Medium", 9F);
            labelOngkir.ForeColor = Color.FromArgb(77, 59, 47);
            labelOngkir.Location = new Point(13, 115);
            labelOngkir.Name = "labelOngkir";
            labelOngkir.Size = new Size(79, 15);
            labelOngkir.TabIndex = 3;
            labelOngkir.Text = "Ongkos Kirim";
            // 
            // labelPajak
            // 
            labelPajak.AutoSize = true;
            labelPajak.BackColor = Color.Transparent;
            labelPajak.Font = new Font("Gilroy-Medium", 9F);
            labelPajak.ForeColor = Color.FromArgb(77, 59, 47);
            labelPajak.Location = new Point(13, 87);
            labelPajak.Name = "labelPajak";
            labelPajak.Size = new Size(39, 15);
            labelPajak.TabIndex = 2;
            labelPajak.Text = "Pajak";
            // 
            // labelSubTotal
            // 
            labelSubTotal.AutoSize = true;
            labelSubTotal.BackColor = Color.Transparent;
            labelSubTotal.Font = new Font("Gilroy-Medium", 9F);
            labelSubTotal.ForeColor = Color.FromArgb(77, 59, 47);
            labelSubTotal.Location = new Point(13, 59);
            labelSubTotal.Name = "labelSubTotal";
            labelSubTotal.Size = new Size(57, 15);
            labelSubTotal.TabIndex = 1;
            labelSubTotal.Text = "Subtotal";
            // 
            // labelDetailPesanan
            // 
            labelDetailPesanan.AutoSize = true;
            labelDetailPesanan.BackColor = Color.FromArgb(232, 227, 207);
            labelDetailPesanan.FlatStyle = FlatStyle.Flat;
            labelDetailPesanan.Font = new Font("Gilroy-Bold", 10F);
            labelDetailPesanan.Location = new Point(10, 9);
            labelDetailPesanan.Name = "labelDetailPesanan";
            labelDetailPesanan.Padding = new Padding(77, 10, 77, 10);
            labelDetailPesanan.Size = new Size(230, 38);
            labelDetailPesanan.TabIndex = 0;
            labelDetailPesanan.Text = "Ringkasan";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(232, 227, 207);
            panel1.Location = new Point(10, 289);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 38);
            panel1.TabIndex = 5;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(700, 338);
            Controls.Add(detail_pesanan);
            Controls.Add(pnlContent);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainView";
            Text = "MainView";
            detail_pesanan.ResumeLayout(false);
            detail_pesanan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContent;
        private Panel detail_pesanan;
        private Label labelTotal;
        private Label labelOngkir;
        private Label labelPajak;
        private Label labelSubTotal;
        private Label labelDetailPesanan;
        private Panel panel1;
    }
}