namespace OrderTrack.view.UserControls // Namespace untuk UserControl Anda
{
    partial class HomePageUserControl // Keyword 'partial'
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null; // Variabel IContainer

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) // Metode Dispose
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code // Region untuk kode desainer

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() // Metode InitializeComponent
        {
            // Resource manager untuk mengambil gambar atau sumber daya lainnya
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageUserControl));

            // Instansiasi Kontrol UI
            btnBuatPesanan = new Button();
            btnPesanan = new Button();
            btnKeranjang = new Button();
            t1_homepage = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();

            // Memulai penangguhan layouting untuk PictureBox
            // Ini untuk kinerja saat menginisialisasi PictureBox dan gambarnya
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();

            // Memulai penangguhan layouting untuk UserControl itu sendiri
            SuspendLayout();

            // --- Konfigurasi Detail Setiap Kontrol ---

            //
            // btnBuatPesanan
            //
            btnBuatPesanan.BackColor = Color.FromArgb(232, 227, 207); // Warna latar belakang tombol
            btnBuatPesanan.FlatStyle = FlatStyle.Flat; // Gaya visual tombol (flat, tidak ada efek 3D)
            btnBuatPesanan.Font = new Font("Microsoft Sans Serif", 10F); // Font tombol
            btnBuatPesanan.ForeColor = Color.FromArgb(77, 59, 47); // Warna teks tombol
            btnBuatPesanan.Location = new Point(47, 288); // Posisi X, Y relatif terhadap UserControl
            btnBuatPesanan.Name = "btnBuatPesanan"; // Nama variabel kontrol
            btnBuatPesanan.Size = new Size(384, 52); // Ukuran tombol
            btnBuatPesanan.TabIndex = 0; // Urutan fokus keyboard (tab order)
            btnBuatPesanan.Text = "Buat Pesanan"; // Teks yang ditampilkan pada tombol
            btnBuatPesanan.UseVisualStyleBackColor = false; // Memastikan warna BackColor kustom digunakan
            btnBuatPesanan.Click += btnBuatPesanan_Click; // Menambahkan event handler untuk event Click
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
            // Catatan: Tidak ada event handler Click yang ditambahkan di Designer.cs untuk btnPesanan.
            // Ini mungkin akan ditambahkan di HomePageUserControl.cs jika ada fungsionalitas.

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
            btnKeranjang.Click += btnKeranjang_Click; // Menambahkan event handler untuk event Click
            //
            // t1_homepage
            //
            t1_homepage.AutoSize = true; // Mengatur ukuran label agar pas dengan teks
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
            // Teks multi-baris yang akan ditampilkan
            label1.Text = "Selamat datang di Brownies Kalingga\nYuk, pesan brownies favoritmu sekarang. \nBikin hari kamu makin istimewa!";
            //
            // pictureBox1
            //
            // Mengambil gambar dari sumber daya proyek.
            // resources.GetObject("pictureBox1.Image") mengambil gambar yang disimpan di file .resx proyek.
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(408, -144); // Posisi PictureBox (mungkin di luar area pandang awal atau sebagai latar belakang)
            pictureBox1.Margin = new Padding(3, 4, 3, 4); // Margin/Padding
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(565, 651); // Ukuran PictureBox
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Mode ukuran gambar (Zoom: menjaga rasio aspek)
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false; // Mengindikasikan bahwa kontrol ini tidak dapat menerima fokus tab
            //
            // HomePageUserControl
            //
            AutoScaleDimensions = new SizeF(8F, 20F); // Skala otomatis berdasarkan DPI/font
            AutoScaleMode = AutoScaleMode.Font; // Mode skala otomatis
            BackColor = Color.FromArgb(77, 59, 47); // Warna latar belakang UserControl
            // Menambahkan semua kontrol yang sudah dibuat ke dalam koleksi Controls UserControl
            Controls.Add(label1);
            Controls.Add(t1_homepage);
            Controls.Add(btnKeranjang);
            Controls.Add(btnPesanan);
            Controls.Add(btnBuatPesanan);
            Controls.Add(pictureBox1); // Penting: pictureBox1 ditambahkan terakhir, yang berarti akan berada di belakang kontrol lain secara default
            Location = new Point(357, -108); // Posisi UserControl (ini tidak relevan karena akan di-dock di pnlContent MainView)
            Name = "HomePageUserControl"; // Nama UserControl
            Size = new Size(800, 451); // Ukuran default UserControl ini
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit(); // Mengakhiri penangguhan layouting untuk PictureBox
            ResumeLayout(false); // Mengakhiri penangguhan layouting untuk UserControl
            PerformLayout(); // Memaksa UserControl untuk mengatur ulang layout anak-anaknya
        }

        #endregion // Akhir region kode desainer

        // --- Deklarasi Variabel Anggota untuk Kontrol UI ---
        // Ini adalah deklarasi kontrol-kontrol yang akan diakses di HomePageUserControl.cs
        private Button btnBuatPesanan;
        private Button btnPesanan;
        private Button btnKeranjang;
        private Label t1_homepage;
        private Label label1;
        private PictureBox pictureBox1;
    }
}