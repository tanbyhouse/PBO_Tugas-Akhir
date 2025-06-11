namespace OrderTrack.view.UserControls
{
    partial class HomePageUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageUserControl));
            btnBuatPesanan = new Button();
            btnPesanan = new Button();
            btnKeranjang = new Button();
            t1_homepage = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBuatPesanan
            // 
            btnBuatPesanan.BackColor = Color.FromArgb(232, 227, 207);
            btnBuatPesanan.FlatStyle = FlatStyle.Flat;
            btnBuatPesanan.Font = new Font("Microsoft Sans Serif", 10F);
            btnBuatPesanan.ForeColor = Color.FromArgb(77, 59, 47);
            btnBuatPesanan.Location = new Point(47, 288);
            btnBuatPesanan.Name = "btnBuatPesanan";
            btnBuatPesanan.Size = new Size(384, 52);
            btnBuatPesanan.TabIndex = 0;
            btnBuatPesanan.Text = "Buat Pesanan";
            btnBuatPesanan.UseVisualStyleBackColor = false;
            btnBuatPesanan.Click += btnBuatPesanan_Click;
            // 
            // btnPesanan
            // 
            btnPesanan.BackColor = Color.Tan;
            btnPesanan.FlatStyle = FlatStyle.Flat;
            btnPesanan.Font = new Font("Microsoft Sans Serif", 10F);
            btnPesanan.ForeColor = Color.FromArgb(77, 59, 47);
            btnPesanan.Location = new Point(47, 351);
            btnPesanan.Name = "btnPesanan";
            btnPesanan.Size = new Size(197, 52);
            btnPesanan.TabIndex = 1;
            btnPesanan.Text = "Pesanan Saya";
            btnPesanan.UseVisualStyleBackColor = false;
            // 
            // btnKeranjang
            // 
            btnKeranjang.BackColor = Color.Tan;
            btnKeranjang.FlatStyle = FlatStyle.Flat;
            btnKeranjang.Font = new Font("Microsoft Sans Serif", 10F);
            btnKeranjang.ForeColor = Color.FromArgb(77, 59, 47);
            btnKeranjang.Location = new Point(253, 351);
            btnKeranjang.Name = "btnKeranjang";
            btnKeranjang.Size = new Size(178, 52);
            btnKeranjang.TabIndex = 2;
            btnKeranjang.Text = "Keranjang";
            btnKeranjang.UseVisualStyleBackColor = false;
            btnKeranjang.Click += btnKeranjang_Click;
            // 
            // t1_homepage
            // 
            t1_homepage.AutoSize = true;
            t1_homepage.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            t1_homepage.ForeColor = Color.FromArgb(232, 227, 207);
            t1_homepage.Location = new Point(41, 60);
            t1_homepage.Name = "t1_homepage";
            t1_homepage.Size = new Size(275, 55);
            t1_homepage.TabIndex = 3;
            t1_homepage.Text = "OrderTrack";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = Color.FromArgb(232, 227, 207);
            label1.Location = new Point(49, 133);
            label1.Name = "label1";
            label1.Size = new Size(318, 60);
            label1.TabIndex = 4;
            label1.Text = "Selamat datang di Brownies Kalingga\nYuk, pesan brownies favoritmu sekarang. \nBikin hari kamu makin istimewa!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(408, -144);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(565, 651);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // HomePageUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(77, 59, 47);
            Controls.Add(label1);
            Controls.Add(t1_homepage);
            Controls.Add(btnKeranjang);
            Controls.Add(btnPesanan);
            Controls.Add(btnBuatPesanan);
            Controls.Add(pictureBox1);
            Location = new Point(357, -108);
            Name = "HomePageUserControl";
            Size = new Size(800, 451);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuatPesanan;
        private Button btnPesanan;
        private Button btnKeranjang;
        private Label t1_homepage;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
