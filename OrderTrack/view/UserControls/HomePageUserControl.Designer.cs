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
            btnBuatPesanan = new Button();
            btnPesanan = new Button();
            btnKeranjang = new Button();
            SuspendLayout();
            // 
            // btnBuatPesanan
            // 
            btnBuatPesanan.Location = new Point(282, 227);
            btnBuatPesanan.Name = "btnBuatPesanan";
            btnBuatPesanan.Size = new Size(260, 55);
            btnBuatPesanan.TabIndex = 0;
            btnBuatPesanan.Text = "Buat Pesanan";
            btnBuatPesanan.UseVisualStyleBackColor = true;
            btnBuatPesanan.Click += btnRegister_Click;
            // 
            // btnPesanan
            // 
            btnPesanan.Location = new Point(282, 288);
            btnPesanan.Name = "btnPesanan";
            btnPesanan.Size = new Size(127, 55);
            btnPesanan.TabIndex = 1;
            btnPesanan.Text = "Pesanan Saya";
            btnPesanan.UseVisualStyleBackColor = true;
            // 
            // btnKeranjang
            // 
            btnKeranjang.Location = new Point(415, 288);
            btnKeranjang.Name = "btnKeranjang";
            btnKeranjang.Size = new Size(127, 55);
            btnKeranjang.TabIndex = 2;
            btnKeranjang.Text = "Keranjang";
            btnKeranjang.UseVisualStyleBackColor = true;
            btnKeranjang.Click += btnKeranjang_Click;
            // 
            // HomePageUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnKeranjang);
            Controls.Add(btnPesanan);
            Controls.Add(btnBuatPesanan);
            Name = "HomePageUserControl";
            Size = new Size(800, 450);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuatPesanan;
        private Button btnPesanan;
        private Button btnKeranjang;
    }
}
