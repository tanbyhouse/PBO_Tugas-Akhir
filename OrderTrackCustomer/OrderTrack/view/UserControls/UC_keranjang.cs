using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderTrack.Models_s;
using OrderTrack.utils;
using OrderTrack.view.UserControls;

namespace OrderTrack.view.UserControls
{
    public partial class UC_keranjang : UserControl
    {
        // Event untuk memberitahu MainView agar menavigasi ke UserControl lain
        public event EventHandler<NavigationEventArgs> NavigateToUserControlRequested;
        // Event untuk memberitahu MainView tentang update summary keranjang (real-time)
        public event EventHandler<CartSummaryUpdateEventArgs> CartSummaryUpdated;

        private List<Browny> _keranjangItems;
        private Dictionary<int, int> _quantityKeranjang;
        private Dictionary<int, QuantityBox> _produkQuantityControls; // Referensi QuantityBox dari UC_produk

        // Properties untuk menerima data keranjang dari UC_produk saat navigasi
        public List<Browny> KeranjangItems
        {
            get { return _keranjangItems; }
            set { _keranjangItems = value; }
        }
        public Dictionary<int, int> QuantityKeranjang
        {
            get { return _quantityKeranjang; }
            set { _quantityKeranjang = value; }
        }
        public Dictionary<int, QuantityBox> ProdukQuantityControls
        {
            get { return _produkQuantityControls; }
            set { _produkQuantityControls = value; }
        }

        // Hapus SEMUA deklarasi Label untuk Sub Total, Pajak, Ongkir, Total jika mereka hanya ada di MainView.
        // Jika Anda MEMANG punya sidebar ringkasan di UC_keranjang, maka biarkan deklarasi label di UC_keranjang.Designer.cs
        // dan tambahkan di sini:
        // public Label lblSubTotalValue;
        // public Label lblPajakValue;
        // public Label lblOngkirValue;
        // public Label lblTotalValue;

        public UC_keranjang()
        {
            InitializeComponent();
            _keranjangItems = new List<Browny>();
            _quantityKeranjang = new Dictionary<int, int>();
        }

        // Metode publik yang akan dipanggil oleh UC_produk atau MainView untuk memuat dan menampilkan data
        public void LoadKeranjangDataAndDisplay()
        {
            DisplayKeranjangItems();
        }

        // Metode pemicu event NavigateToUserControlRequested
        protected virtual void OnNavigateToUserControlRequested(NavigationEventArgs e)
        {
            NavigateToUserControlRequested?.Invoke(this, e);
        }

        // Metode pemicu event CartSummaryUpdated
        protected virtual void OnCartSummaryUpdated(CartSummaryUpdateEventArgs e)
        {
            CartSummaryUpdated?.Invoke(this, e);
        }

        private void DisplayKeranjangItems()
        {
            flowPanelKeranjangItemsHost.Controls.Clear();

            decimal currentSubtotal = 0;

            // Tampilkan pesan "Keranjang kosong" jika tidak ada item
            if (_keranjangItems == null || !_keranjangItems.Any() || _quantityKeranjang == null || !_quantityKeranjang.Any(kv => kv.Value > 0))
            {
                Label lblEmpty = new Label();
                lblEmpty.Text = "Keranjang Anda kosong.";
                lblEmpty.Font = new Font("Segoe UI", 12, FontStyle.Italic);
                lblEmpty.AutoSize = false;
                lblEmpty.Dock = DockStyle.Fill;
                lblEmpty.TextAlign = ContentAlignment.MiddleCenter;
                flowPanelKeranjangItemsHost.Controls.Add(lblEmpty);

                // Memicu event dengan nilai 0 saat keranjang kosong ke MainView
                OnCartSummaryUpdated(new CartSummaryUpdateEventArgs(0, 0, 0, 0));
                return;
            }

            // Filter item yang benar-benar ada di keranjang dengan kuantitas > 0
            var activeKeranjangItems = _keranjangItems
                .Where(item => _quantityKeranjang.ContainsKey(item.IdBrownies) && _quantityKeranjang[item.IdBrownies] > 0)
                .OrderBy(b => b.NamaBrownies)
                .ToList();

            foreach (var item in activeKeranjangItems)
            {
                int qty = _quantityKeranjang[item.IdBrownies];

                RoundedPanel itemPanel = new RoundedPanel();
                itemPanel.CornerRadius = 10;
                itemPanel.BorderColor = ColorTranslator.FromHtml("#e8e3cf");
                itemPanel.BorderThickness = 1;
                itemPanel.Size = new Size(flowPanelKeranjangItemsHost.ClientSize.Width - 15, 110);
                itemPanel.Margin = new Padding(5);
                itemPanel.BackColor = ColorTranslator.FromHtml("#FFF8EA");
                itemPanel.Tag = item.IdBrownies;

                PictureBox itemPic = new PictureBox();
                itemPic.Size = new Size(100, 100);
                itemPic.SizeMode = PictureBoxSizeMode.Zoom;
                itemPic.Location = new Point(5, 5);
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", item.GambarPath);
                if (File.Exists(imagePath))
                {
                    try { itemPic.Image = Image.FromFile(imagePath); } catch { itemPic.Image = new Bitmap(1, 1); }
                }
                else { itemPic.Image = new Bitmap(1, 1); }
                itemPanel.Controls.Add(itemPic);

                Label lblName = new Label();
                lblName.Text = item.NamaBrownies;
                lblName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblName.Location = new Point(itemPic.Right + 10, 10);
                lblName.AutoSize = false;
                int nameWidth = itemPanel.Width - itemPic.Right - 10 - 150;
                lblName.Size = new Size(nameWidth, 25);
                lblName.AutoEllipsis = true;
                itemPanel.Controls.Add(lblName);

                Label lblPrice = new Label();
                lblPrice.Text = $"Rp. {item.HargaBrownies:N0}";
                lblPrice.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                lblPrice.Location = new Point(itemPic.Right + 10, lblName.Bottom + 5);
                lblPrice.AutoSize = true;
                itemPanel.Controls.Add(lblPrice);

                QuantityBox qtyBox = new QuantityBox();
                qtyBox.Minimum = 0;
                qtyBox.Maximum = 200;
                qtyBox.Value = qty;
                qtyBox.Location = new Point(itemPic.Right + 10, lblPrice.Bottom + 5);
                qtyBox.Size = new Size(100, 28);
                qtyBox.Tag = item.IdBrownies;

                // Event handler untuk perubahan nilai QuantityBox di halaman keranjang
                qtyBox.ValueChanged += (s, ev) =>
                {
                    QuantityBox senderQtyBox = s as QuantityBox;
                    int changedId = (int)senderQtyBox.Tag;
                    int changedQty = senderQtyBox.Value;

                    if (changedQty > 0) { _quantityKeranjang[changedId] = changedQty; }
                    else
                    {
                        _keranjangItems.RemoveAll(b => b.IdBrownies == changedId);
                        _quantityKeranjang.Remove(changedId);
                    }

                    // Update QuantityBox di PRODUK LAYOUT PANEL (sisi kiri) juga!
                    if (_produkQuantityControls != null && _produkQuantityControls.ContainsKey(changedId))
                    {
                        _produkQuantityControls[changedId].Value = changedQty;
                    }
                    DisplayKeranjangItems(); // Memicu refresh tampilan internal dan event summary ke MainView
                };
                itemPanel.Controls.Add(qtyBox);

                Button btnRemove = new Button();
                string trashIconPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "trash_icon.png");
                if (File.Exists(trashIconPath)) { btnRemove.BackgroundImage = Image.FromFile(trashIconPath); }
                else
                {
                    btnRemove.Text = "X";
                    btnRemove.ForeColor = Color.Red;
                }
                btnRemove.BackgroundImageLayout = ImageLayout.Zoom;
                btnRemove.Size = new Size(30, 30);
                btnRemove.Location = new Point(itemPanel.Width - btnRemove.Width - 10, itemPic.Top + (itemPic.Height / 2) - (btnRemove.Height / 2));
                btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                btnRemove.FlatStyle = FlatStyle.Flat;
                btnRemove.FlatAppearance.BorderSize = 0;
                btnRemove.BackColor = Color.Transparent;
                btnRemove.Cursor = Cursors.Hand;
                btnRemove.Tag = item.IdBrownies;

                // Event handler untuk tombol hapus item dari keranjang
                btnRemove.Click += (s, ev) =>
                {
                    int idToRemove = (int)((Button)s).Tag;
                    _keranjangItems.RemoveAll(b => b.IdBrownies == idToRemove);
                    _quantityKeranjang.Remove(idToRemove);

                    if (_produkQuantityControls != null && _produkQuantityControls.ContainsKey(idToRemove))
                    {
                        _produkQuantityControls[idToRemove].Value = 0; // Reset di halaman produk
                    }
                    DisplayKeranjangItems(); // Memicu refresh tampilan internal dan event summary ke MainView
                };
                itemPanel.Controls.Add(btnRemove);

                currentSubtotal += (item.HargaBrownies * qty);
                flowPanelKeranjangItemsHost.Controls.Add(itemPanel);
            }

            decimal pajakRate = 0.1m;
            decimal ongkosKirim = activeKeranjangItems.Any() ? 12000m : 0m;
            decimal totalPajak = currentSubtotal * pajakRate;
            decimal finalTotal = currentSubtotal + totalPajak + ongkosKirim;

            // --- HANYA MENGIRIMKAN EVENT KE MAINVIEW, TIDAK MENGUPDATE LABEL LOKAL ---
            // Karena label-label summary sekarang sudah dipastikan di MainView
            OnCartSummaryUpdated(new CartSummaryUpdateEventArgs(currentSubtotal, totalPajak, ongkosKirim, finalTotal));
        }

        // Event handler untuk tombol "Kembali" (kembali ke UC_produk)
        private void btnBack_Click(object sender, EventArgs e)
        {
            UC_produk produkUC = new UC_produk();
            // Navigasi ke UC_produk. pnlSummaryKeranjang di MainView harus terlihat (true).
            NavigateToUserControlRequested?.Invoke(this, new(produkUC, false, true));
        }

        // Event handler untuk tombol "Checkout" (menuju halaman konfirmasi nama)
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            UC_confirmName uC_ConfirmName = new UC_confirmName();
            // Navigasi ke UC_confirmName. pnlSummaryKeranjang di MainView harus terlihat (true).
            NavigateToUserControlRequested?.Invoke(this, new NavigationEventArgs(uC_ConfirmName, false, false));
        }

        private void btnCheckout_Click_1(object sender, EventArgs e)
        {
            UC_confirmName uC_ConfirmName = new UC_confirmName();
            // Navigasi ke UC_confirmName. pnlSummaryKeranjang di MainView harus terlihat (true).
            NavigateToUserControlRequested?.Invoke(this, new NavigationEventArgs(uC_ConfirmName, false, false));
        }
    }
}
