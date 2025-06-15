using OrderTrackOwner.Data.Context_s;
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
    public partial class FormPilihStatus : Form
    {
        public StatusPesanan StatusTerpilih { get; private set; }
        public int Id_Pesanan { get; set; }

        public FormPilihStatus()
        {
            InitializeComponent();
            comboBoxStatus.DataSource = Enum.GetValues(typeof(StatusPesanan));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StatusTerpilih = (StatusPesanan)comboBoxStatus.SelectedItem;

            using (var db = new AppDbContext_s())
            {
                var pesananGrid = db.Pesanan.Find(this.Id_Pesanan);
                if (pesananGrid != null)
                {
                    pesananGrid.StatusPesanan = StatusTerpilih;
                    db.SaveChanges(); // Penting: simpan perubahan ke database
                }
            }

            // Tambahkan event agar UC_DaftarPesanan bisa refresh data
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
