namespace OrderTrackOwner.view
{
    partial class UC_DaftarPesanan
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
            dataGridViewPesanan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesanan).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPesanan
            // 
            dataGridViewPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesanan.Dock = DockStyle.Fill;
            dataGridViewPesanan.Location = new Point(0, 0);
            dataGridViewPesanan.Name = "Daftar Pesanan Owner";
            dataGridViewPesanan.RowHeadersWidth = 51;
            dataGridViewPesanan.Size = new Size(818, 497);
            dataGridViewPesanan.TabIndex = 0;
            // 
            // UC_DaftarPesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewPesanan);
            Name = "UC_DaftarPesanan";
            Size = new Size(818, 497);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesanan).EndInit();
            

        }

        #endregion

        private DataGridView dataGridViewPesanan;
    }
}
