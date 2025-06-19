using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderTrack.Models_s;

namespace OrderTrack.view.UserControls
{
    partial class UC_produk
    {
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
    }
}
