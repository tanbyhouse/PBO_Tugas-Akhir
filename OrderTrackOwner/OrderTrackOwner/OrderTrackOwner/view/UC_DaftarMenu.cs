using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderTrackOwner.Data.Context_s;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace OrderTrackOwner.view
{
    public partial class UC_DaftarMenu : UserControl
    {
        AppDbContext_s _dbContext = new AppDbContext_s();
        public UC_DaftarMenu()
        {
            InitializeComponent();
            LoadMenuData();
        }
        private async void LoadMenuData()
        {
            try
            {
                dataMenu.DataSource = await _dbContext.Brownies.ToListAsync();
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error memuat data menu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dataMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataMenu.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (dataMenu.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult result = MessageBox.Show(
                        "Anda yakin ingin menghapus produk ini?",
                        "Konfirmasi Hapus",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // Ambil ID produk dari baris yang diklik
                            // Asumsi kolom pertama (indeks 0) adalah IdVarian, atau Anda bisa ambil dari Tag
                            int productId = (int)dataMenu.Rows[e.RowIndex].Cells["IdVarian"].Value; // Sesuaikan dengan DataPropertyName IdVarian Anda

                            // Cari produk di database
                            var productToDelete = await _dbContext.Brownies.FindAsync(productId);

                            if (productToDelete != null)
                            {
                                // Hapus gambar terkait jika ada
                                if (!string.IsNullOrEmpty(productToDelete.GambarPath))
                                {
                                    string imageBasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
                                    string fullImagePath = Path.Combine(imageBasePath, productToDelete.GambarPath);
                                    if (File.Exists(fullImagePath))
                                    {
                                        File.Delete(fullImagePath);
                                        Console.WriteLine($"Gambar {productToDelete.GambarPath} berhasil dihapus.");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Gambar {fullImagePath} tidak ditemukan untuk dihapus.");
                                    }
                                }

                                _dbContext.Brownies.Remove(productToDelete);
                                await _dbContext.SaveChangesAsync(); // Simpan perubahan ke database

                                MessageBox.Show("Produk berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadMenuData(); // Muat ulang data untuk memperbarui tampilan
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error menghapus produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                // Anda akan menambahkan logika untuk tombol "Edit" di sini juga nanti
                // else if (dataMenu.Columns[e.ColumnIndex].Name == "Edit")
                // {
                //     // Logika edit
                // }
            }
        }
    }
}