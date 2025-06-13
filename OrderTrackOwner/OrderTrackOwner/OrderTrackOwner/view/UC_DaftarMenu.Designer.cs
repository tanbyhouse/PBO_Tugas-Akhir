using System.Drawing.Drawing2D;

namespace OrderTrackOwner.view
{
    partial class UC_DaftarMenu : UserControl
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
            if (disposing && _dbContext != null)
            {
                _dbContext.Dispose();
                _dbContext = null;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataMenu = new DataGridView();
            Delete = new DataGridViewButtonColumn();
            IdBrownies = new DataGridViewTextBoxColumn();
            IdVarian = new DataGridViewTextBoxColumn();
            NamaBrownies = new DataGridViewTextBoxColumn();
            KuantitasBrownies = new DataGridViewTextBoxColumn();
            SatuanKuantitas = new DataGridViewTextBoxColumn();
            HargaBrownies = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            GambarPath = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataMenu).BeginInit();
            SuspendLayout();
            // 
            // dataMenu
            // 
            dataMenu.AllowUserToOrderColumns = true;
            dataMenu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataMenu.Columns.AddRange(new DataGridViewColumn[] { Delete, IdBrownies, IdVarian, NamaBrownies, KuantitasBrownies, SatuanKuantitas, HargaBrownies, Deskripsi, GambarPath });
            dataMenu.Dock = DockStyle.Top;
            dataMenu.Location = new Point(0, 0);
            dataMenu.Name = "dataMenu";
            dataMenu.RowHeadersWidth = 51;
            dataMenu.Size = new Size(818, 440);
            dataMenu.TabIndex = 0;
            dataMenu.CellContentClick += dataMenu_CellContentClick;
            // 
            // Delete
            // 
            Delete.HeaderText = "Hapus Data";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Hapus";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 125;
            // 
            // IdBrownies
            // 
            IdBrownies.DataPropertyName = "IdBrownies";
            IdBrownies.HeaderText = "ID Brownies";
            IdBrownies.MinimumWidth = 6;
            IdBrownies.Name = "IdBrownies";
            IdBrownies.Width = 125;
            // 
            // IdVarian
            // 
            IdVarian.DataPropertyName = "IdVarian";
            IdVarian.HeaderText = "ID Varian";
            IdVarian.MinimumWidth = 6;
            IdVarian.Name = "IdVarian";
            IdVarian.Resizable = DataGridViewTriState.True;
            IdVarian.SortMode = DataGridViewColumnSortMode.NotSortable;
            IdVarian.Width = 125;
            // 
            // NamaBrownies
            // 
            NamaBrownies.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            NamaBrownies.DataPropertyName = "NamaBrownies";
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            NamaBrownies.DefaultCellStyle = dataGridViewCellStyle1;
            NamaBrownies.HeaderText = "Nama Brownies";
            NamaBrownies.MinimumWidth = 6;
            NamaBrownies.Name = "NamaBrownies";
            NamaBrownies.Width = 130;
            // 
            // KuantitasBrownies
            // 
            KuantitasBrownies.DataPropertyName = "KuantitasBrownies";
            KuantitasBrownies.HeaderText = "Kuantitas Brownies";
            KuantitasBrownies.MinimumWidth = 6;
            KuantitasBrownies.Name = "KuantitasBrownies";
            KuantitasBrownies.Width = 125;
            // 
            // SatuanKuantitas
            // 
            SatuanKuantitas.DataPropertyName = "SatuanKuantitas";
            SatuanKuantitas.HeaderText = "Satuan Kuantitas";
            SatuanKuantitas.MinimumWidth = 6;
            SatuanKuantitas.Name = "SatuanKuantitas";
            SatuanKuantitas.Resizable = DataGridViewTriState.True;
            SatuanKuantitas.SortMode = DataGridViewColumnSortMode.NotSortable;
            SatuanKuantitas.Width = 125;
            // 
            // HargaBrownies
            // 
            HargaBrownies.DataPropertyName = "HargaBrownies";
            HargaBrownies.HeaderText = "Harga Brownies";
            HargaBrownies.MinimumWidth = 6;
            HargaBrownies.Name = "HargaBrownies";
            HargaBrownies.Width = 125;
            // 
            // Deskripsi
            // 
            Deskripsi.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Deskripsi.DataPropertyName = "Deskripsi";
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Deskripsi.DefaultCellStyle = dataGridViewCellStyle2;
            Deskripsi.HeaderText = "Deskripsi";
            Deskripsi.MinimumWidth = 6;
            Deskripsi.Name = "Deskripsi";
            Deskripsi.Width = 98;
            // 
            // GambarPath
            // 
            GambarPath.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            GambarPath.DataPropertyName = "GambarPath";
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            GambarPath.DefaultCellStyle = dataGridViewCellStyle3;
            GambarPath.HeaderText = "Gambar";
            GambarPath.MinimumWidth = 6;
            GambarPath.Name = "GambarPath";
            GambarPath.Width = 91;
            // 
            // UC_DaftarMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataMenu);
            Name = "UC_DaftarMenu";
            Size = new Size(818, 497);
            ((System.ComponentModel.ISupportInitialize)dataMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataMenu;
        private DataGridViewButtonColumn Delete;
        private DataGridViewTextBoxColumn IdBrownies;
        private DataGridViewTextBoxColumn IdVarian;
        private DataGridViewTextBoxColumn NamaBrownies;
        private DataGridViewTextBoxColumn KuantitasBrownies;
        private DataGridViewTextBoxColumn SatuanKuantitas;
        private DataGridViewTextBoxColumn HargaBrownies;
        private DataGridViewTextBoxColumn Deskripsi;
        private DataGridViewTextBoxColumn GambarPath;
    }
}
