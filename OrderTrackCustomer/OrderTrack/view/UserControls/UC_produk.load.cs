using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderTrack.Models_s;
using OrderTrack.utils;

namespace OrderTrack.view.UserControls
{
    public partial class UC_produk
    {
        // method yang menampilkan UI dinamis sesuai dari objek data di database 
        private async void LoadProdukData()
        {
            // langkah 1: mengambil data produk brownies dari class Browny
            List<Browny> brownieslist = new List<Browny>();
            try
            {
                brownieslist = await _dbcontext.Brownies.ToListAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Akhir Langkah 1

            // Langkah 2: Menangani kasus apabila tabel di database kosong (tidak ada data yang bisa dimuat)
            if (brownieslist == null || !brownieslist.Any())
            {
                Label lblNoData = new Label();
                lblNoData.Text = "Maaf, data produk belum tersedia.";
                lblNoData.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                lblNoData.AutoSize = true;
                lblNoData.TextAlign = ContentAlignment.MiddleCenter;
                this.produkLayoutPanel.Controls.Add(lblNoData);
                lblNoData.Anchor = AnchorStyles.None;
                return;
            }
            // Akhir Langkah 2

            // Langkah 3: mengatur data untuk gambar karena agak susah jika menyimpan bit data di db maka
            // disimpan dalam bentuk path yang disimpan di bin
            string imageBasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            // Akhir Langkah 3

            // Langkah 4: melakukan iterasi data yang telah diambil dari class Browny
            // membuat sebuah komponen UI dinamis dari masing-masing datanya secara manual
            foreach (var brownies in brownieslist)
            {
                RoundedPanel productPanel = new RoundedPanel();
                productPanel.CornerRadius = 15;
                productPanel.BorderColor = ColorTranslator.FromHtml("#e8e3cf");
                productPanel.BorderThickness = 1;
                productPanel.Size = new Size(180, 270);
                productPanel.BorderStyle = BorderStyle.None;
                productPanel.Margin = new Padding(5);
                productPanel.BackColor = ColorTranslator.FromHtml("#e8e3cf");
                productPanel.Tag = brownies;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(160, 140);
                pictureBox.BackColor = Color.Transparent;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Location = new Point(10, 30);

                string fullImagePath = Path.Combine(imageBasePath, brownies.GambarPath);
                if (File.Exists(fullImagePath))
                {
                    try
                    {
                        pictureBox.Image = Image.FromFile(fullImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Console.WriteLine($"File gambar tidak ditemukan: {fullImagePath}");
                    pictureBox.Image = new Bitmap(1, 1);
                }

                Label lblNama = new Label();
                lblNama.Text = brownies.NamaBrownies;
                lblNama.BackColor = Color.Tan;
                lblNama.Font = new Font("Gilroy-Bold", 10, FontStyle.Bold);
                lblNama.TextAlign = ContentAlignment.MiddleCenter;
                lblNama.Size = new Size(productPanel.Width, 30);

                Label lblHarga = new Label();
                lblHarga.Text = $"Rp. {brownies.HargaBrownies:N0}";
                lblHarga.TextAlign = ContentAlignment.MiddleCenter;
                lblHarga.Location = new Point((productPanel.Width - lblHarga.PreferredWidth) / 2, 170);
                lblHarga.AutoSize = true;
                lblHarga.BackColor = Color.Transparent;
                lblHarga.Font = new Font("Gilroy-Medium", 9, FontStyle.Regular);

                Button btnDetail = new Button();
                btnDetail.BackColor = Color.Tan;
                btnDetail.FlatStyle = FlatStyle.Flat;
                btnDetail.FlatAppearance.BorderSize = 0;
                btnDetail.ForeColor = ColorTranslator.FromHtml("#4D3B2F");
                btnDetail.Font = new Font("Gilroy-Bold", 10, FontStyle.Regular);
                btnDetail.Location = new Point(0, 195);
                btnDetail.Size = new Size(productPanel.Width, 30);
                btnDetail.Text = "Detail Produk";
                btnDetail.Click += (sender, e) => ShowProductDetail(brownies);

                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(lblNama);
                productPanel.Controls.Add(lblHarga);
                productPanel.Controls.Add(btnDetail);

                this.produkLayoutPanel.Controls.Add(productPanel);

                QuantityBox quantityBox = new QuantityBox();
                quantityBox.Minimum = 0;
                quantityBox.Maximum = 200;
                // Penting: Set nilai awal dari keranjang jika sudah ada
                quantityBox.Value = _quantityKeranjang.GetValueOrDefault(brownies.IdBrownies, 0); // Ambil kuantitas dari keranjang jika ada

                quantityBox.Location = new Point(15, 232);
                quantityBox.Name = "quantityBox_" + brownies.IdBrownies;
                quantityBox.Tag = brownies.IdBrownies; // PENTING: Set Tag agar QuantityBox_ValueChanged tahu produk mana

                // PENTING: Attach event handler di sini!
                quantityBox.ValueChanged += QuantityBox_ValueChanged; // Ini akan memicu update sidebar secara langsung

                _quantityControls[brownies.IdBrownies] = quantityBox;
                productPanel.Controls.Add(quantityBox);
            }
            // Akhir Langkah 4

            // Langkah 5: Setelah semua produk dimuat, perbarui sidebar untuk menampilkan item yang mungkin sudah ada di keranjang dari sesi sebelumnya
            UpdateKeranjangSideBar(); // Panggil di sini juga untuk inisialisasi awal
            // Akhir Langkah 5
        }
    }
}
