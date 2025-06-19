namespace OrderTrack.view.UserControls
{
    public partial class QuantityBox : UserControl
    {
        public event EventHandler ValueChanged; // Event yang dipicu saat nilai berubah
        public int Minimum { get; set; } = 0;   // Properti untuk nilai minimum
        public int Maximum { get; set; } = 200; // Properti untuk nilai maksimum

        public int Value // Properti utama untuk mendapatkan/mengatur nilai kuantitas
        {
            get => int.Parse(lblValue.Text); // Mengambil nilai dari Label
            set
            {
                // Memastikan nilai berada di antara Minimum dan Maximum
                int val = Math.Max(Minimum, Math.Min(Maximum, value));
                lblValue.Text = val.ToString(); // Memperbarui tampilan Label
                btnMinus.Enabled = val > Minimum; // Mengaktifkan/menonaktifkan tombol Minus
                btnPlus.Enabled = val < Maximum;   // Mengaktifkan/menonaktifkan tombol Plus
            }
        }

        public QuantityBox() // Konstruktor QuantityBox
        {
            InitializeComponent(); // Inisialisasi komponen UI dari designer
            Value = 0;             // Mengatur nilai awal ke 0
        }

        private void btnMinus_Click(object sender, EventArgs e) // Event handler untuk tombol Minus
        {
            if (Value > Minimum) // Cek agar tidak kurang dari minimum
            {
                Value--; // Kurangi nilai
                ValueChanged?.Invoke(this, EventArgs.Empty); // Picu event ValueChanged
            }
        }

        private void btnPlus_Click(object sender, EventArgs e) // Event handler untuk tombol Plus
        {
            if (Value < Maximum) // Cek agar tidak lebih dari maksimum
            {
                Value++; // Tambah nilai
                ValueChanged?.Invoke(this, EventArgs.Empty); // Picu event ValueChanged
            }
        }
    }
}