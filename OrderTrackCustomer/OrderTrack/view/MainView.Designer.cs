namespace OrderTrack.view // Namespace yang sama dengan MainView.cs
{
    partial class MainView // Keyword 'partial'
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null; // Deklarasi Variabel Anggota 'components'

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) // Metode 'Dispose'
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code // Region untuk kode desainer

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() // Metode 'InitializeComponent'
        {
            pnlContent = new Panel();
            pnlSummaryKeranjang = new Panel();
            lblTotalValue = new Label();
            lblOngkirValue = new Label();
            lblPajakValue = new Label();
            lblSubTotalValue = new Label();
            lblTotalStatic = new Label();
            lblOngkirStatic = new Label();
            lblPajakStatic = new Label();
            lblSubTotalStatic = new Label();
            lblResiPembayaran = new Label();
            pnlContent.SuspendLayout();
            pnlSummaryKeranjang.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(pnlSummaryKeranjang);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(800, 450);
            pnlContent.TabIndex = 0;
            // 
            // pnlSummaryKeranjang
            // 
            pnlSummaryKeranjang.BackColor = Color.FromArgb(215, 206, 191);
            pnlSummaryKeranjang.Controls.Add(lblTotalValue);
            pnlSummaryKeranjang.Controls.Add(lblOngkirValue);
            pnlSummaryKeranjang.Controls.Add(lblPajakValue);
            pnlSummaryKeranjang.Controls.Add(lblSubTotalValue);
            pnlSummaryKeranjang.Controls.Add(lblTotalStatic);
            pnlSummaryKeranjang.Controls.Add(lblOngkirStatic);
            pnlSummaryKeranjang.Controls.Add(lblPajakStatic);
            pnlSummaryKeranjang.Controls.Add(lblSubTotalStatic);
            pnlSummaryKeranjang.Controls.Add(lblResiPembayaran);
            pnlSummaryKeranjang.Dock = DockStyle.Right;
            pnlSummaryKeranjang.Location = new Point(566, 0);
            pnlSummaryKeranjang.Name = "pnlSummaryKeranjang";
            pnlSummaryKeranjang.Size = new Size(234, 450);
            pnlSummaryKeranjang.TabIndex = 7;
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Location = new Point(120, 352);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(42, 20);
            lblTotalValue.TabIndex = 12;
            lblTotalValue.Text = "Rp. 0";
            // 
            // lblOngkirValue
            // 
            lblOngkirValue.AutoSize = true;
            lblOngkirValue.Location = new Point(120, 178);
            lblOngkirValue.Name = "lblOngkirValue";
            lblOngkirValue.Size = new Size(42, 20);
            lblOngkirValue.TabIndex = 11;
            lblOngkirValue.Text = "Rp. 0";
            // 
            // lblPajakValue
            // 
            lblPajakValue.AutoSize = true;
            lblPajakValue.Location = new Point(120, 135);
            lblPajakValue.Name = "lblPajakValue";
            lblPajakValue.Size = new Size(42, 20);
            lblPajakValue.TabIndex = 10;
            lblPajakValue.Text = "Rp. 0";
            // 
            // lblSubTotalValue
            // 
            lblSubTotalValue.AutoSize = true;
            lblSubTotalValue.Location = new Point(120, 94);
            lblSubTotalValue.Name = "lblSubTotalValue";
            lblSubTotalValue.Size = new Size(42, 20);
            lblSubTotalValue.TabIndex = 9;
            lblSubTotalValue.Text = "Rp. 0";
            // 
            // lblTotalStatic
            // 
            lblTotalStatic.AutoSize = true;
            lblTotalStatic.Location = new Point(12, 352);
            lblTotalStatic.Name = "lblTotalStatic";
            lblTotalStatic.Size = new Size(49, 20);
            lblTotalStatic.TabIndex = 8;
            lblTotalStatic.Text = "Total :";
            // 
            // lblOngkirStatic
            // 
            lblOngkirStatic.AutoSize = true;
            lblOngkirStatic.Location = new Point(12, 178);
            lblOngkirStatic.Name = "lblOngkirStatic";
            lblOngkirStatic.Size = new Size(105, 20);
            lblOngkirStatic.TabIndex = 7;
            lblOngkirStatic.Text = "Ongkos Kirim :";
            // 
            // lblPajakStatic
            // 
            lblPajakStatic.AutoSize = true;
            lblPajakStatic.Location = new Point(12, 135);
            lblPajakStatic.Name = "lblPajakStatic";
            lblPajakStatic.Size = new Size(50, 20);
            lblPajakStatic.TabIndex = 6;
            lblPajakStatic.Text = "Pajak :";
            // 
            // lblSubTotalStatic
            // 
            lblSubTotalStatic.AutoSize = true;
            lblSubTotalStatic.Location = new Point(12, 94);
            lblSubTotalStatic.Name = "lblSubTotalStatic";
            lblSubTotalStatic.Size = new Size(78, 20);
            lblSubTotalStatic.TabIndex = 5;
            lblSubTotalStatic.Text = "Sub Total :";
            // 
            // lblResiPembayaran
            // 
            lblResiPembayaran.AutoSize = true;
            lblResiPembayaran.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResiPembayaran.Location = new Point(25, 8);
            lblResiPembayaran.Name = "lblResiPembayaran";
            lblResiPembayaran.Size = new Size(187, 36);
            lblResiPembayaran.TabIndex = 4;
            lblResiPembayaran.Text = "Resi Pembayaran";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainView";
            Text = "MainView";
            pnlContent.ResumeLayout(false);
            pnlSummaryKeranjang.ResumeLayout(false);
            pnlSummaryKeranjang.PerformLayout();
            ResumeLayout(false);
        }

        #endregion // Akhir region kode desainer

        // --- Deklarasi Variabel Anggota untuk Kontrol UI ---
        // Ini adalah deklarasi kontrol-kontrol yang akan diakses di MainView.cs
        private Panel pnlContent;
        private Panel pnlSummaryKeranjang;
        private Label lblTotalValue;
        private Label lblOngkirValue;
        private Label lblPajakValue;
        private Label lblSubTotalValue;
        private Label lblTotalStatic;
        private Label lblOngkirStatic;
        private Label lblPajakStatic;
        private Label lblSubTotalStatic;
        private Label lblResiPembayaran;
    }
}