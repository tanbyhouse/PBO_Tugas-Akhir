using Microsoft.EntityFrameworkCore;
using OrderTrackOwner.Data.Context_s;
using OrderTrackOwner.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OrderTrackOwner.view
{
    public partial class UC_DaftarPesanan : UserControl
    {
        AppDbContext_s _dbContext;

        public event EventHandler<NavigateEventArgs> NavigateTouserControlRequested;
        public UC_DaftarPesanan()
        {
            InitializeComponent();
            _dbContext = new AppDbContext_s();
            
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "UbahStatusColumn";
            btnColumn.HeaderText = "Ubah Status";
            btnColumn.Text = "Ubah";
            btnColumn.UseColumnTextForButtonValue = true;
            dataGridViewPesanan.Columns.Add(btnColumn);

            LoadPesanan();
            dataGridViewPesanan.CellContentClick += dataGridViewPesanan_CellContentClick;
        }

        private void LoadPesanan(StatusPesanan? statusFilter = null)
        {
            var query = _dbContext.Pesanans
                .Include(p => p.DetailPesanans)
                .AsQueryable();

            if (statusFilter.HasValue)
            {
                query = query.Where(p => p.StatusPesanan == statusFilter.Value);
            }

            dataGridViewPesanan.DataSource = query.ToList();
        }

        private void dataGridViewPesanan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var pesanans = (Pesanan)dataGridViewPesanan.Rows[e.RowIndex].DataBoundItem;
                decimal totalHarga = pesanans.DetailPesanans?.Sum(d => d.TotalHargaItem) ?? 0;

                var detailsMessage = new StringBuilder();
                detailsMessage.AppendLine($"ID Pesanan: {pesanans.IdPesanan}");
                detailsMessage.AppendLine($"Status: {pesanans.StatusPesanan}");
                detailsMessage.AppendLine($"Total Harga: {totalHarga}");

                if (pesanans.DetailPesanans?.Any() == true)
                {
                    detailsMessage.AppendLine("\nDetail Items:");
                    foreach (var detail in pesanans.DetailPesanans)
                    {
                        detailsMessage.AppendLine($"- {detail.IdPesanan} x{detail.JumlahItem}: {detail.TotalHargaItem}");
                    }
                }

                MessageBox.Show(detailsMessage.ToString(), "Detail Pesanan",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewPesanan.Columns["UbahStatusColumn"].Index && e.RowIndex >= 0)
            {
                var pesananGrid = (Pesanan)dataGridViewPesanan.Rows[e.RowIndex].DataBoundItem;

                using (var form = new FormPilihStatus())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        using (var db = new AppDbContext_s())
                        {
                            var pesananDB = db.Pesanans.FirstOrDefault(P => P.IdPesanan == pesananGrid.IdPesanan);

                            if (pesananDB != null)
                            {
                                pesananDB.StatusPesanan = form.StatusTerpilih;
                                db.SaveChanges();
                                LoadPesanan();
                            }
                        }
                    }
                }
            }
        }
        private void btnUbahStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewPesanan.SelectedRows.Count > 0)
            {
                int pesananId = Convert.ToInt32(dataGridViewPesanan.SelectedRows[0].Cells["Id"].Value);
                using (var form = new FormPilihStatus())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // Setelah status diubah, refresh DataGridView
                        LoadPesanan();
                    }
                }
            }
        }
    }
}
