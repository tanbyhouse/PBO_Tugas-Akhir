using System.Data;
using OrderTrack.Models_s;
using OrderTrack.utils;

namespace OrderTrack.view.UserControls
{
    public partial class UC_keranjang : BaseUserControl
    {
        // Akses langsung data static dari UC_produk
        List<Browny> currentKeranjangItems;
        Dictionary<int, int> currentQuantityKeranjang;
        public UC_keranjang()
        {
            InitializeComponent();
            currentKeranjangItems = UC_produk.GetKeranjangItems();
            currentQuantityKeranjang = UC_produk.GetQuantityKeranjang();
        }

        // Metode publik yang akan dipanggil oleh UC_produk atau MainView untuk memuat dan menampilkan data
        public void LoadKeranjangDataAndDisplay()
        {
            DisplayKeranjangItems();
        }

        private void DisplayKeranjangItems()
        {
            flowPanelKeranjangItemsHost.Controls.Clear();
            // Tampilkan pesan "Keranjang kosong" jika tidak ada item
            if (currentKeranjangItems == null || !currentKeranjangItems.Any() || currentQuantityKeranjang == null || !currentQuantityKeranjang.Any(kv => kv.Value > 0))
            {
                emptyPanel.Enabled = true;
                flowPanelKeranjangItemsHost.Controls.Add(emptyPanel);
            }
            // Filter item yang benar-benar ada di keranjang dengan kuantitas > 0 menggunakan LINQ
            var activeKeranjangItems = currentKeranjangItems
                .Where(item => currentQuantityKeranjang.ContainsKey(item.IdBrownies) && currentQuantityKeranjang[item.IdBrownies] > 0)
                .OrderBy(b => b.NamaBrownies)
                .ToList();

            foreach (var item in activeKeranjangItems)
            {
                int qty = currentQuantityKeranjang[item.IdBrownies];

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

                    if (changedQty > 0) { currentQuantityKeranjang[changedId] = changedQty; }
                    else
                    {
                        currentKeranjangItems.RemoveAll(b => b.IdBrownies == changedId);
                        currentQuantityKeranjang.Remove(changedId);
                    }

                    // Update QuantityBox di PRODUK LAYOUT PANEL (sisi kiri) juga!
                    if (UC_produk._quantityControls != null && UC_produk._quantityControls.ContainsKey(changedId))
                    {
                        UC_produk._quantityControls[changedId].Value = changedQty;
                    }
                    UC_produk.NotifyCartDataChange();
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
                    currentKeranjangItems.RemoveAll(b => b.IdBrownies == idToRemove);
                    currentQuantityKeranjang.Remove(idToRemove);

                    if (UC_produk._quantityControls != null && UC_produk._quantityControls.ContainsKey(idToRemove))
                    {
                        UC_produk._quantityControls[idToRemove].Value = 0; // Reset di halaman produk
                    }
                    UC_produk.NotifyCartDataChange();
                    DisplayKeranjangItems(); // Memicu refresh tampilan internal dan event summary ke MainView
                };
                itemPanel.Controls.Add(btnRemove);
               flowPanelKeranjangItemsHost.Controls.Add(itemPanel);
            }
        }
        private void btnCheckout_Click_1(object sender, EventArgs e)
        {
            if (emptyPanel.Enabled == true)
            {
                MessageBox.Show("Tambahkan pesanan sebelum checkout yaa", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            UC_confirmName uC_ConfirmName = new UC_confirmName();
            // Navigasi ke UC_confirmName. pnlSummaryKeranjang di MainView harus terlihat (true).
            OnNavigateToUserControlRequested(new NavigationEventArgs(uC_ConfirmName, true));
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            UC_produk produkUC = new UC_produk();
            // Navigasi ke UC_produk. pnlSummaryKeranjang di MainView harus terlihat (true).
            OnNavigateToUserControlRequested(new NavigationEventArgs(produkUC, false));
        }
    }
}
