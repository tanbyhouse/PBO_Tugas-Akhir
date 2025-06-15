namespace OrderTrack.view.UserControls
{
    partial class UC_produk
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
            // --- Deklarasi dan Instansiasi Kontrol ---
            // Ini adalah daftar semua kontrol yang akan digunakan dalam UC_produk
            pnlProdukContainer = new Panel(); // Panel utama yang akan menampung semua konten UC_produk
            tableLayoutPanelMain = new TableLayoutPanel(); // TableLayoutPanel untuk membagi area utama
            productContainer = new TableLayoutPanel(); // TableLayoutPanel untuk area daftar produk
            btnPanel = new Panel(); // Panel untuk menampung tombol aksi (Keranjang, Kembali)
            btnKeranjang = new Button(); // Tombol "Masukkan Keranjang"
            produkLayoutPanel = new System.Windows.Forms.TableLayoutPanel(); // TableLayoutPanel khusus untuk menampilkan item produk individual (grid produk)
            pnlKeranjangHost = new Panel(); // Panel untuk menampung bagian ringkasan keranjang
            mainTableLayoutPanel = new TableLayoutPanel(); // TableLayoutPanel di dalam pnlKeranjangHost untuk mengatur elemen keranjang
            labelPesananSaya = new Label(); // Label untuk judul "Pesanan Saya" di ringkasan keranjang
            flowPanelKeranjangHostItems = new FlowLayoutPanel(); // FlowLayoutPanel untuk menampilkan daftar item di keranjang (otomatis mengatur ulang)
            pnlSummaryCost = new Panel(); // Panel untuk ringkasan biaya (Sub Total, Pajak, Ongkir)
            lblOngkirStatic = new Label(); // Label statis "Ongkos Kirim :"
            lblPajakStatic = new Label(); // Label statis "Pajak :"
            lblSubTotalStatic = new Label(); // Label statis "Sub Total :"
            lblOngkirValue = new Label(); // Label dinamis untuk nilai ongkos kirim
            lblPajakValue = new Label(); // Label dinamis untuk nilai pajak
            lblSubTotalValue = new Label(); // Label dinamis untuk nilai sub total
            panel1 = new Panel(); // Panel untuk menampilkan total akhir
            lblTotalValue = new Label(); // Label dinamis untuk nilai total
            lblTotalStatic = new Label(); // Label statis "Total :"
            btnBack = new Button(); // Tombol "Kembali"

            // --- Memulai Penangguhan Tata Letak untuk Kontrol Kontainer ---
            // Ini meningkatkan kinerja saat banyak properti diatur
            pnlProdukContainer.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            productContainer.SuspendLayout();
            btnPanel.SuspendLayout();
            pnlKeranjangHost.SuspendLayout();
            mainTableLayoutPanel.SuspendLayout();
            pnlSummaryCost.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout(); // SuspendLayout untuk UC_produk itu sendiri

            // --- Konfigurasi Setiap Kontrol dan Tata Letaknya ---

            //
            // pnlProdukContainer (Panel Utama untuk UC_produk)
            //
            pnlProdukContainer.BackColor = Color.Gray; // Latar belakang abu-abu
            pnlProdukContainer.Controls.Add(tableLayoutPanelMain); // Menambahkan tableLayoutPanelMain ke dalamnya
            pnlProdukContainer.Dock = DockStyle.Fill; // Mengisi seluruh area UC_produk
            pnlProdukContainer.Location = new Point(0, 0); // Posisi awal (top-left)
            pnlProdukContainer.Name = "pnlProdukContainer";
            pnlProdukContainer.Size = new Size(800, 451); // Ukuran default
            pnlProdukContainer.TabIndex = 0;
            //
            // tableLayoutPanelMain (Membagi UC_produk menjadi 2 kolom utama)
            //
            tableLayoutPanelMain.ColumnCount = 2; // Dua kolom
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F)); // Kolom 1: 70% lebar (untuk daftar produk)
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F)); // Kolom 2: 30% lebar (untuk keranjang)
            tableLayoutPanelMain.Controls.Add(productContainer, 0, 0); // Menambahkan productContainer ke Kolom 0, Baris 0
            tableLayoutPanelMain.Controls.Add(pnlKeranjangHost, 1, 0); // Menambahkan pnlKeranjangHost ke Kolom 1, Baris 0
            tableLayoutPanelMain.Dock = DockStyle.Fill; // Mengisi seluruh pnlProdukContainer
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 1; // Hanya satu baris
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F)); // Ini sebenarnya tidak relevan karena hanya ada 1 baris
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F)); // Ini juga tidak relevan
            tableLayoutPanelMain.Size = new Size(800, 451);
            tableLayoutPanelMain.TabIndex = 0;
            //
            // productContainer (TableLayoutPanel untuk Area Produk)
            //
            productContainer.BackColor = Color.FromArgb(77, 59, 47); // Latar belakang cokelat gelap
            productContainer.ColumnCount = 1; // Hanya satu kolom
            productContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F)); // Ini juga tidak relevan karena hanya 1 kolom
            productContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F)); // Ini juga tidak relevan
            productContainer.Controls.Add(btnPanel, 0, 1); // Menambahkan btnPanel ke Kolom 0, Baris 1 (bawah)
            productContainer.Controls.Add(produkLayoutPanel, 0, 0); // Menambahkan produkLayoutPanel ke Kolom 0, Baris 0 (atas)
            productContainer.Dock = DockStyle.Fill; // Mengisi selnya di tableLayoutPanelMain
            productContainer.Location = new Point(3, 3); // Posisi di dalam sel tableLayoutPanelMain (ada padding 3px)
            productContainer.Name = "productContainer";
            productContainer.RowCount = 2; // Dua baris
            productContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 81.57304F)); // Baris 0: 81.5% tinggi (untuk produk list)
            productContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 18.4269657F)); // Baris 1: 18.4% tinggi (untuk tombol)
            productContainer.Size = new Size(554, 445);
            productContainer.TabIndex = 0;
            //
            // btnPanel (Panel untuk Tombol Aksi "Masukkan Keranjang" dan "Kembali")
            //
            btnPanel.BackColor = Color.FromArgb(77, 59, 47); // Latar belakang cokelat gelap
            btnPanel.Controls.Add(btnBack); // Menambahkan tombol "Kembali"
            btnPanel.Controls.Add(btnKeranjang); // Menambahkan tombol "Masukkan Keranjang"
            btnPanel.Dock = DockStyle.Fill; // Mengisi selnya di productContainer
            btnPanel.Location = new Point(3, 365); // Posisi di dalam productContainer
            btnPanel.Margin = new Padding(3, 2, 3, 2);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(548, 78);
            btnPanel.TabIndex = 1;
            //
            // btnKeranjang (Tombol "Masukkan Keranjang")
            //
            btnKeranjang.BackColor = Color.FromArgb(232, 227, 207); // Warna krem muda
            btnKeranjang.FlatStyle = FlatStyle.Flat;
            btnKeranjang.Font = new Font("Microsoft Sans Serif", 10F);
            btnKeranjang.ForeColor = Color.FromArgb(77, 59, 47);
            btnKeranjang.Location = new Point(276, 18); // Posisi di dalam btnPanel
            btnKeranjang.Margin = new Padding(3, 2, 3, 2);
            btnKeranjang.Name = "btnKeranjang";
            btnKeranjang.Size = new Size(227, 48);
            btnKeranjang.TabIndex = 1;
            btnKeranjang.Text = "Masukkan Keranjang";
            btnKeranjang.UseVisualStyleBackColor = false;
            btnKeranjang.Click += btnKeranjang_Click; // Event handler Click
            //
            // produkLayoutPanel (TableLayoutPanel untuk Daftar Produk, akan diisi secara dinamis)
            //
            produkLayoutPanel.AutoScroll = true; // Akan muncul scrollbar jika konten melebihi ukuran
            produkLayoutPanel.ColumnCount = 3; // Tiga kolom (untuk menampilkan produk dalam grid)
            produkLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F)); // Masing-masing 33.33%
            produkLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            produkLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            produkLayoutPanel.Dock = DockStyle.Fill; // Mengisi selnya di productContainer
            produkLayoutPanel.Location = new Point(3, 3);
            produkLayoutPanel.Name = "produkLayoutPanel";
            produkLayoutPanel.RowCount = 2; // Dua baris awal (ini bisa bertambah secara dinamis)
            produkLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F)); // Masing-masing 50%
            produkLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            produkLayoutPanel.Size = new Size(548, 357);
            produkLayoutPanel.TabIndex = 2;
            //
            // pnlKeranjangHost (Panel untuk Area Ringkasan Keranjang)
            //
            pnlKeranjangHost.BackColor = Color.FromArgb(232, 227, 207); // Latar belakang krem muda
            pnlKeranjangHost.Controls.Add(mainTableLayoutPanel); // Menambahkan mainTableLayoutPanel ke dalamnya
            pnlKeranjangHost.Dock = DockStyle.Fill; // Mengisi selnya di tableLayoutPanelMain
            pnlKeranjangHost.Location = new Point(563, 3); // Posisi di dalam sel tableLayoutPanelMain (ada padding 3px)
            pnlKeranjangHost.Name = "pnlKeranjangHost";
            pnlKeranjangHost.Size = new Size(234, 445);
            pnlKeranjangHost.TabIndex = 1;
            //
            // mainTableLayoutPanel (TableLayoutPanel untuk Konten Keranjang)
            //
            mainTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single; // Garis batas antar sel
            mainTableLayoutPanel.ColumnCount = 1; // Hanya satu kolom
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(labelPesananSaya, 0, 0); // Label "Pesanan Saya" di Baris 0
            mainTableLayoutPanel.Controls.Add(flowPanelKeranjangHostItems, 0, 1); // Daftar item keranjang di Baris 1
            mainTableLayoutPanel.Controls.Add(pnlSummaryCost, 0, 2); // Ringkasan biaya di Baris 2
            mainTableLayoutPanel.Controls.Add(panel1, 0, 3); // Total akhir di Baris 3
            mainTableLayoutPanel.Dock = DockStyle.Fill; // Mengisi pnlKeranjangHost
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 4; // Empat baris
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 7.78688526F)); // Baris 0 (judul): ~7.7%
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 61.47541F)); // Baris 1 (item): ~61.4%
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20.4918041F)); // Baris 2 (summary): ~20.4%
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.2459021F)); // Baris 3 (total): ~10.2%
            mainTableLayoutPanel.Size = new Size(234, 445);
            mainTableLayoutPanel.TabIndex = 0;
            //
            // labelPesananSaya (Label Judul di Area Keranjang)
            //
            labelPesananSaya.AutoSize = true;
            labelPesananSaya.BackColor = Color.FromArgb(232, 227, 207); // Latar belakang krem muda (sama dengan pnlKeranjangHost)
            labelPesananSaya.FlatStyle = FlatStyle.Flat;
            labelPesananSaya.Font = new Font("Microsoft Sans Serif", 13F);
            labelPesananSaya.Location = new Point(4, 1); // Posisi di dalam sel mainTableLayoutPanel
            labelPesananSaya.Name = "labelPesananSaya";
            labelPesananSaya.Size = new Size(154, 26);
            labelPesananSaya.TabIndex = 0;
            labelPesananSaya.Text = "Pesanan Saya";
            labelPesananSaya.TextAlign = ContentAlignment.MiddleLeft; // Penataan teks
            //
            // flowPanelKeranjangHostItems (FlowLayoutPanel untuk Daftar Item Keranjang)
            //
            flowPanelKeranjangHostItems.AutoScroll = true; // Akan muncul scrollbar jika item melebihi ukuran
            flowPanelKeranjangHostItems.BackColor = Color.Transparent; // Latar belakang transparan
            flowPanelKeranjangHostItems.Dock = DockStyle.Fill; // Mengisi selnya di mainTableLayoutPanel
            flowPanelKeranjangHostItems.FlowDirection = FlowDirection.TopDown; // Item akan disusun dari atas ke bawah
            flowPanelKeranjangHostItems.Location = new Point(4, 39);
            flowPanelKeranjangHostItems.Name = "flowPanelKeranjangHostItems";
            flowPanelKeranjangHostItems.Size = new Size(226, 264);
            flowPanelKeranjangHostItems.TabIndex = 1;
            flowPanelKeranjangHostItems.WrapContents = false; // Item tidak akan membungkus ke baris/kolom baru
            //
            // pnlSummaryCost (Panel untuk Ringkasan Biaya)
            //
            pnlSummaryCost.Controls.Add(lblOngkirStatic);
            pnlSummaryCost.Controls.Add(lblPajakStatic);
            pnlSummaryCost.Controls.Add(lblSubTotalStatic);
            pnlSummaryCost.Controls.Add(lblOngkirValue);
            pnlSummaryCost.Controls.Add(lblPajakValue);
            pnlSummaryCost.Controls.Add(lblSubTotalValue);
            pnlSummaryCost.Dock = DockStyle.Fill; // Mengisi selnya di mainTableLayoutPanel
            pnlSummaryCost.Location = new Point(4, 310);
            pnlSummaryCost.Name = "pnlSummaryCost";
            pnlSummaryCost.Size = new Size(226, 84);
            pnlSummaryCost.TabIndex = 2;
            //
            // lblOngkirStatic (Label "Ongkos Kirim :")
            //
            lblOngkirStatic.Anchor = AnchorStyles.Right; // Di-anchor ke kanan
            lblOngkirStatic.AutoSize = true;
            lblOngkirStatic.Location = new Point(5, 59);
            lblOngkirStatic.Name = "lblOngkirStatic";
            lblOngkirStatic.Size = new Size(105, 20);
            lblOngkirStatic.TabIndex = 5;
            lblOngkirStatic.Text = "Ongkos Kirim :";
            //
            // lblPajakStatic (Label "Pajak :")
            //
            lblPajakStatic.Anchor = AnchorStyles.Right;
            lblPajakStatic.AutoSize = true;
            lblPajakStatic.Location = new Point(5, 34);
            lblPajakStatic.Name = "lblPajakStatic";
            lblPajakStatic.Size = new Size(50, 20);
            lblPajakStatic.TabIndex = 4;
            lblPajakStatic.Text = "Pajak :";
            //
            // lblSubTotalStatic (Label "Sub Total :")
            //
            lblSubTotalStatic.Anchor = AnchorStyles.Right;
            lblSubTotalStatic.AutoSize = true;
            lblSubTotalStatic.Location = new Point(5, 6);
            lblSubTotalStatic.Name = "lblSubTotalStatic";
            lblSubTotalStatic.Size = new Size(78, 20);
            lblSubTotalStatic.TabIndex = 3;
            lblSubTotalStatic.Text = "Sub Total :";
            //
            // lblOngkirValue (Nilai Ongkos Kirim)
            //
            lblOngkirValue.AutoSize = true;
            lblOngkirValue.Location = new Point(151, 59); // Posisi agar sejajar dengan lblOngkirStatic
            lblOngkirValue.Name = "lblOngkirValue";
            lblOngkirValue.Size = new Size(17, 20);
            lblOngkirValue.TabIndex = 2;
            lblOngkirValue.Text = "0"; // Nilai awal
            //
            // lblPajakValue (Nilai Pajak)
            //
            lblPajakValue.AutoSize = true;
            lblPajakValue.Location = new Point(151, 34); // Posisi agar sejajar dengan lblPajakStatic
            lblPajakValue.Name = "lblPajakValue";
            lblPajakValue.Size = new Size(17, 20);
            lblPajakValue.TabIndex = 1;
            lblPajakValue.Text = "0"; // Nilai awal
            //
            // lblSubTotalValue (Nilai Sub Total)
            //
            lblSubTotalValue.Anchor = AnchorStyles.Top | AnchorStyles.Right; // Di-anchor ke atas dan kanan
            lblSubTotalValue.AutoSize = true;
            lblSubTotalValue.Location = new Point(151, 6); // Posisi agar sejajar dengan lblSubTotalStatic
            lblSubTotalValue.Name = "lblSubTotalValue";
            lblSubTotalValue.Size = new Size(17, 20);
            lblSubTotalValue.TabIndex = 0;
            lblSubTotalValue.Text = "0"; // Nilai awal
            lblSubTotalValue.TextAlign = ContentAlignment.MiddleRight; // Penataan teks
            //
            // panel1 (Panel untuk Total Akhir)
            //
            panel1.Controls.Add(lblTotalValue);
            panel1.Controls.Add(lblTotalStatic);
            panel1.Dock = DockStyle.Fill; // Mengisi selnya di mainTableLayoutPanel
            panel1.Location = new Point(4, 401);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 40);
            panel1.TabIndex = 3;
            //
            // lblTotalValue (Nilai Total Akhir)
            //
            lblTotalValue.Anchor = AnchorStyles.Right; // Di-anchor ke kanan
            lblTotalValue.AutoSize = true;
            lblTotalValue.Location = new Point(151, 10); // Posisi agar sejajar dengan lblTotalStatic
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(17, 20);
            lblTotalValue.TabIndex = 1;
            lblTotalValue.Text = "0"; // Nilai awal
            lblTotalValue.TextAlign = ContentAlignment.TopCenter;
            lblTotalValue.UseMnemonic = false; // Mengabaikan ampersand (&) sebagai mnemonic
            //
            // lblTotalStatic (Label "Total :")
            //
            lblTotalStatic.AutoSize = true;
            lblTotalStatic.Location = new Point(7, 10);
            lblTotalStatic.Name = "lblTotalStatic";
            lblTotalStatic.Size = new Size(49, 20);
            lblTotalStatic.TabIndex = 0;
            lblTotalStatic.Text = "Total :";
            lblTotalStatic.TextAlign = ContentAlignment.TopCenter;
            lblTotalStatic.UseMnemonic = false;
            //
            // btnBack (Tombol "Kembali")
            //
            btnBack.BackColor = Color.FromArgb(232, 227, 207);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft Sans Serif", 10F);
            btnBack.ForeColor = Color.FromArgb(77, 59, 47);
            btnBack.Location = new Point(31, 18); // Posisi di dalam btnPanel
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(227, 48);
            btnBack.TabIndex = 2;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click; // Event handler Click
            //
            // UC_produk (UserControl itu sendiri)
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlProdukContainer); // Menambahkan pnlProdukContainer sebagai kontrol utama
            Name = "UC_produk";
            Size = new Size(800, 451);
            // Mengakhiri penangguhan layouting untuk semua kontrol kontainer
            pnlProdukContainer.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            productContainer.ResumeLayout(false);
            btnPanel.ResumeLayout(false);
            pnlKeranjangHost.ResumeLayout(false);
            mainTableLayoutPanel.ResumeLayout(false);
            mainTableLayoutPanel.PerformLayout(); // Memaksa layout ulang
            pnlSummaryCost.ResumeLayout(false);
            pnlSummaryCost.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false); // Mengakhiri penangguhan layouting untuk UC_produk
        }

        #endregion

        // --- Deklarasi Variabel Anggota untuk Kontrol UI ---
        // Ini memungkinkan akses ke kontrol-kontrol ini dari file UC_produk.cs
        private Panel pnlProdukContainer;
        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel productContainer;
        private Panel btnPanel;
        private Button btnKeranjang;
        private System.Windows.Forms.TableLayoutPanel produkLayoutPanel;
        private Panel pnlKeranjangHost;
        private TableLayoutPanel mainTableLayoutPanel;
        private Label labelPesananSaya;
        private FlowLayoutPanel flowPanelKeranjangHostItems;
        private Panel pnlSummaryCost;
        private Label lblSubTotalValue;
        private Label lblPajakValue;
        private Label lblOngkirValue;
        private Label lblOngkirStatic;
        private Label lblPajakStatic;
        private Label lblSubTotalStatic;
        private Panel panel1;
        private Label lblTotalValue;
        private Label lblTotalStatic;
        private Button btnBack;
    }
}