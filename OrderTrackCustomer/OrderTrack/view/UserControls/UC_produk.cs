using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing; // Untuk kelas Image, Bitmap, Point, Size
using System.IO;    // Untuk Path, Directory
using System.Linq;  // Untuk ToList(), FirstOrDefault(), Where()
using System.Threading.Tasks; // Untuk async/await jika menggunakan ToListAsync()
using OrderTrack.Data.Context_s;
using OrderTrack.Models_s;
using OrderTrack.utils;
using OrderTrack.view.UserControls;
using Microsoft.EntityFrameworkCore;

namespace OrderTrack.view.UserControls
{

    public partial class UC_produk : UserControl
    {
        private readonly AppDbContext_s _dbcontext;
        public EventHandler<NavigationEventArgs> NavigateToUserControlRequested;
        public UC_produk()
        {
            InitializeComponent();
            _dbcontext = new AppDbContext_s();

            LoadProdukData();
        }
        private async void LoadProdukData()
        {
            this.panel1.Controls.Clear();

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

            if (brownieslist == null || !brownieslist.Any()) 
            {
                Label lblNoData = new Label();
                lblNoData.Text = "Maaf, data produk belum tersedia.";
                lblNoData.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                lblNoData.AutoSize = true;
                lblNoData.TextAlign = ContentAlignment.MiddleCenter; 
                this.tableLayoutPanel1.Controls.Add(lblNoData); 
                lblNoData.Anchor = AnchorStyles.None;

                this.panel1.Controls.Add(this.tableLayoutPanel1);

                return; 
            }

            string imageBasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            foreach (var brownies in brownieslist)
            {
                /* INI GATAU AKU JIR CARANYA BIAR ROUNDED GIMANA 
                soalnya bentuk kotaknya lancip*/
                //Panel productPanel = new Panel();
                RoundedPanel productPanel = new RoundedPanel();
                productPanel.CornerRadius = 15; 
                productPanel.BorderColor = Color.White;
                productPanel.BorderThickness = 2; 
                productPanel.Size = new Size(180, 270);
                productPanel.BorderStyle = BorderStyle.None; 
                productPanel.Margin = new Padding(10);
                productPanel.BackColor = Color.Red; 
                productPanel.Tag = brownies;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(160, 140);
                pictureBox.BackColor = Color.Transparent;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Location = new Point(10, 10);

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
                lblNama.Location = new Point(5, 160);
                lblNama.AutoSize = true;
                lblNama.BackColor = Color.Transparent;
                lblNama.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lblNama.MaximumSize = new Size(170, 0);

                Label lblHarga = new Label();
                lblHarga.Text = $"Rp. {brownies.HargaBrownies:N0}";
                lblHarga.Location = new Point(5, 185);
                lblHarga.AutoSize = true;
                lblHarga.BackColor = Color.Transparent;
                lblHarga.Font = new Font("Segoe UI", 9, FontStyle.Regular);

                Button btnDetail = new Button();
                btnDetail.Text = "Detail Produk";
                btnDetail.Location = new Point(5, 215);
                btnDetail.Size = new Size(100, 25);
                //btnDetail.BackColor = Color.FromArgb(210, 180, 140);
                btnDetail.Click += (sender, e) => ShowProductDetail(brownies);

                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(lblNama);
                productPanel.Controls.Add(lblHarga);
                productPanel.Controls.Add(btnDetail);

                panel1.Controls.Add(productPanel);
            }
        }
        private void ShowProductDetail(Browny selectedBrownies)
        {
            Form detailForm = new Form();
            detailForm.Text = "Detail Produk: " + selectedBrownies.NamaBrownies;
            detailForm.Size = new Size(400, 550);
            detailForm.StartPosition = FormStartPosition.CenterScreen;

            PictureBox detailPictureBox = new PictureBox();
            detailPictureBox.Size = new Size(300, 250);
            detailPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            detailPictureBox.Location = new Point(50, 20);

            string imageBasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            string fullImagePath = Path.Combine(imageBasePath, selectedBrownies.GambarPath);
            if (File.Exists(fullImagePath))
            {
                try
                {
                    detailPictureBox.Image = Image.FromFile(fullImagePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Gagal memuat gambar detail dari {fullImagePath}: {ex.Message}");
                    detailPictureBox.Image = new Bitmap(1, 1);
                }
            }
            else
            {
                Console.WriteLine($"File gambar detail tidak ditemukan: {fullImagePath}");
                detailPictureBox.Image = new Bitmap(1, 1);
            }

            Label lblDetailNama = new Label();
            lblDetailNama.Text = "Nama: " + selectedBrownies.NamaBrownies;
            lblDetailNama.Location = new Point(50, 280);
            lblDetailNama.AutoSize = true;
            lblDetailNama.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            Label lblDetailHarga = new Label();
            lblDetailHarga.Text = $"Harga: Rp. {selectedBrownies.HargaBrownies:N0}";
            lblDetailHarga.Location = new Point(50, 310);
            lblDetailHarga.AutoSize = true;
            lblDetailHarga.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            Label lblDetailDeskripsi = new Label();
            lblDetailDeskripsi.Text = "Deskripsi: " + selectedBrownies.Deskripsi;
            lblDetailDeskripsi.Location = new Point(50, 340);
            lblDetailDeskripsi.MaximumSize = new Size(300, 0);
            lblDetailDeskripsi.AutoSize = true;
            lblDetailDeskripsi.Font = new Font("Segoe UI", 9, FontStyle.Italic);

            detailForm.Controls.Add(detailPictureBox);
            detailForm.Controls.Add(lblDetailNama);
            detailForm.Controls.Add(lblDetailHarga);
            detailForm.Controls.Add(lblDetailDeskripsi);

            detailForm.ShowDialog();
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            UC_keranjang keranjang = new UC_keranjang();

            NavigateToUserControlRequested?.Invoke(this, new NavigationEventArgs(keranjang, true, true));
        }
        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesanan telah masuk ke keranjang silahkan cek keranjang anda", "Pesanan Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
