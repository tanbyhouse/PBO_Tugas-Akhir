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
            btnMenu = new Button();
            btnLaporan = new Button();
            btnPesanan = new Button();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(340, 445);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(160, 29);
            btnMenu.TabIndex = 0;
            btnMenu.Text = " Daftar Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.Location = new Point(683, 27);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(94, 29);
            btnLaporan.TabIndex = 1;
            btnLaporan.Text = "Laporan";
            btnLaporan.UseVisualStyleBackColor = true;
            // 
            // btnPesanan
            // 
            btnPesanan.Location = new Point(42, 27);
            btnPesanan.Name = "btnPesanan";
            btnPesanan.Size = new Size(160, 29);
            btnPesanan.TabIndex = 2;
            btnPesanan.Text = "Daftar Pesanan";
            btnPesanan.UseVisualStyleBackColor = true;
            btnPesanan.Click += btnPesanan_Click;
            // 
            // UC_HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPesanan);
            Controls.Add(btnLaporan);
            Controls.Add(btnMenu);
            Name = "UC_HomePage";
            Size = new Size(818, 497);
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenu;
        private Button btnLaporan;
        private Button btnPesanan;
    }
}
