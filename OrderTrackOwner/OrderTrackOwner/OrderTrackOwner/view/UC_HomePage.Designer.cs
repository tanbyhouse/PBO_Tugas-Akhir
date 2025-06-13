namespace OrderTrackOwner.view
{
    partial class UC_HomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HomePage));
            btnMenu = new Button();
            btnLaporan = new Button();
            btnPesanan = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.FlatAppearance.BorderColor = Color.FromArgb(77, 59, 47);
            btnMenu.FlatAppearance.BorderSize = 2;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Gilroy-Bold", 10F);
            btnMenu.ForeColor = Color.FromArgb(77, 59, 47);
            btnMenu.Location = new Point(87, 179);
            btnMenu.Margin = new Padding(3, 2, 3, 2);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(161, 37);
            btnMenu.TabIndex = 0;
            btnMenu.Text = " Daftar Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.FlatAppearance.BorderColor = Color.FromArgb(77, 59, 47);
            btnLaporan.FlatAppearance.BorderSize = 2;
            btnLaporan.FlatStyle = FlatStyle.Flat;
            btnLaporan.Font = new Font("Gilroy-Bold", 10F);
            btnLaporan.ForeColor = Color.FromArgb(77, 59, 47);
            btnLaporan.Location = new Point(254, 179);
            btnLaporan.Margin = new Padding(3, 2, 3, 2);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(106, 37);
            btnLaporan.TabIndex = 1;
            btnLaporan.Text = "Laporan";
            btnLaporan.UseVisualStyleBackColor = true;
            // 
            // btnPesanan
            // 
            btnPesanan.BackColor = Color.FromArgb(77, 59, 47);
            btnPesanan.FlatStyle = FlatStyle.Flat;
            btnPesanan.Font = new Font("Gilroy-Bold", 10F);
            btnPesanan.ForeColor = Color.FromArgb(232, 227, 207);
            btnPesanan.Location = new Point(87, 140);
            btnPesanan.Margin = new Padding(3, 2, 3, 2);
            btnPesanan.Name = "btnPesanan";
            btnPesanan.Size = new Size(273, 35);
            btnPesanan.TabIndex = 2;
            btnPesanan.Text = "Daftar Pesanan";
            btnPesanan.UseVisualStyleBackColor = false;
            btnPesanan.Click += btnPesanan_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(77, 59, 47);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -243);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(715, 922);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(btnLaporan);
            panel1.Controls.Add(btnPesanan);
            panel1.Location = new Point(134, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 293);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gilroy-Bold", 23F);
            label1.ForeColor = Color.FromArgb(77, 59, 47);
            label1.Location = new Point(134, 243);
            label1.Name = "label1";
            label1.Size = new Size(177, 39);
            label1.TabIndex = 3;
            label1.Text = "OrderTrack";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gilroy-Medium", 10F);
            label2.ForeColor = Color.FromArgb(77, 59, 47);
            label2.Location = new Point(62, 58);
            label2.Name = "label2";
            label2.Size = new Size(325, 51);
            label2.TabIndex = 4;
            label2.Text = "Pastikan untuk mengecek dan memproses setiap\npesanan dengan cepat dan tepat agar \npelanggan mendapatkan pengalaman terbaik";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gilroy-Bold", 10F);
            label3.ForeColor = Color.FromArgb(77, 59, 47);
            label3.Location = new Point(134, 27);
            label3.Name = "label3";
            label3.Size = new Size(170, 18);
            label3.TabIndex = 5;
            label3.Text = "Selamat datang, Owner!";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 227, 207);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_HomePage";
            Size = new Size(716, 373);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenu;
        private Button btnLaporan;
        private Button btnPesanan;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}
