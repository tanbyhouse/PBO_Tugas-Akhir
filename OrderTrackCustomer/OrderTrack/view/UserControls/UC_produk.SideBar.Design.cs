using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderTrack.utils;

namespace OrderTrack.view.UserControls
{
    partial class UC_produk
    {
        // method untuk menampilkan UI sidebar sebelah kanan
        private void UpdateKeranjangSideBar()
        {
            // Langkah 6: Tiap method ini dipanggil, maka isi dari panel flowPanelKeranjangHostItems
            // akan dibersihkan untuk update tiap iterasinya
            flowPanelKeranjangHostItems.Controls.Clear();
            // Akhir langkah 6

            // Langkah 7: Inisialisasi tiap value dari variabel angka yang ada
            // saat pertama kali muncul maka semua akan di set ke 0
            decimal subtotal = 0;
            decimal pajakrate = 0.1m; // 10%
            decimal ongkir = 0m;
            // Akhir langkah 7 (koreksi nomor langkah dari Anda)

            // Langkah 8: memeriksa apakah sudah terdapat objek di _keranjangItems (untuk menentukan ongkir)
            if (_keranjangItems.Any())
            {
                ongkir = 12000;
            }
            else 
            {
                showEmptyPanel();
            }
            // Langkah 9: Ketika belum ada objek yang ditambahkan maka akan memberitahu kalau
            // keranjang masih kosong

            // Akhir langkah 9

            // Pastikan _keranjangItems memiliki item unik dan sesuai dengan _quantityKeranjang
            // Ada kemungkinan _keranjangItems memiliki duplikat jika item ditambahkan berulang kali
            // tanpa mekanisme pengecekan, atau jika kuantitas diubah ke 0 tetapi item tidak dihapus.
            // Filter item yang benar-benar ada di _quantityKeranjang dengan qty > 0.

            // Langkah 10: Melakukan filtering untuk UI. disini akan di check kebenaran terkait jumlah produk yang diambil
            // harus memenuhi dua syarat yakni memiliki id dan jumlahnya lebih dari 0 yang akan disimpan dalam bentuk
            // list di currentKeranjangItems
            var currentKeranjangItems = _keranjangItems
                .Where(item => _quantityKeranjang.ContainsKey(item.IdBrownies) && _quantityKeranjang[item.IdBrownies] > 0)
                .ToList();
            // Akhir langkah 10

            // Langkah 11: Mengatur UI untuk ditampilkan untuk setiap elemen di keranjang
            foreach (var item in currentKeranjangItems.OrderBy(b => b.NamaBrownies)) // Urutkan berdasarkan nama
            {
                // membuat sebuah variabel untuk menyimpan nilai sesuai dengan id brownies nya
                int qty = _quantityKeranjang.GetValueOrDefault(item.IdBrownies, 0);
                // Posisi label pajak dan ongkir ini mungkin lebih cocok di luar loop jika itu label statis di UC_produk.
                lblPajakValue.Location = new Point(117, 34);
                lblOngkirValue.Location = new Point(117, 59);

                // Hanya proses jika kuantitas lebih dari 0 (sudah difilter di Langkah 10, tapi ini double-check yang aman)
                if (qty > 0)
                {
                    // Buat Panel untuk setiap item keranjang
                    RoundedPanel itemKeranjangPanel = new RoundedPanel();
                    itemKeranjangPanel.CornerRadius = 10;
                    itemKeranjangPanel.BorderColor = ColorTranslator.FromHtml("#e8e3cf");
                    itemKeranjangPanel.BorderThickness = 1;
                    itemKeranjangPanel.Size = new Size(flowPanelKeranjangHostItems.ClientSize.Width - 15, 100); // Dinamis
                    itemKeranjangPanel.BorderStyle = BorderStyle.None;
                    itemKeranjangPanel.Margin = new Padding(5);
                    itemKeranjangPanel.BackColor = ColorTranslator.FromHtml("#FFF8EA");

                    // --- Tambahkan Kontrol ke itemKeranjangPanel ---

                    // Gambar Produk (PictureBox)
                    PictureBox itemPictureBox = new PictureBox();
                    itemPictureBox.Size = new Size(80, 80);
                    itemPictureBox.Location = new Point(5, 5);
                    itemPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    itemPictureBox.BackColor = Color.Transparent;
                    string imageBasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
                    string fullImagePath = Path.Combine(imageBasePath, item.GambarPath);
                    if (File.Exists(fullImagePath))
                    {
                        try { itemPictureBox.Image = Image.FromFile(fullImagePath); }
                        catch { itemPictureBox.Image = new Bitmap(1, 1); }
                    }
                    else { itemPictureBox.Image = new Bitmap(1, 1); }
                    itemKeranjangPanel.Controls.Add(itemPictureBox);

                    // Label Nama Produk
                    Label lblNamaProdukKeranjang = new Label();
                    lblNamaProdukKeranjang.Location = new Point(itemPictureBox.Right + 10, 5);
                    lblNamaProdukKeranjang.AutoSize = false;
                    lblNamaProdukKeranjang.Size = new Size(itemKeranjangPanel.Width - itemPictureBox.Width - 120, 20); // Lebar dinamis
                    lblNamaProdukKeranjang.Text = item.NamaBrownies;
                    lblNamaProdukKeranjang.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    lblNamaProdukKeranjang.MaximumSize = new Size(lblNamaProdukKeranjang.Width, 0);
                    lblNamaProdukKeranjang.AutoEllipsis = true;
                    itemKeranjangPanel.Controls.Add(lblNamaProdukKeranjang);

                    // Label Harga Per Item (Harga total untuk kuantitas item ini)
                    Label lblHargaItem = new Label();
                    lblHargaItem.Text = $"Rp. {item.HargaBrownies * qty:N0}"; // Harga per item * kuantitas
                    lblHargaItem.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    lblHargaItem.AutoSize = true;
                    lblHargaItem.Location = new Point(itemKeranjangPanel.Width - lblHargaItem.PreferredWidth - 20, 5);
                    lblHargaItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                    itemKeranjangPanel.Controls.Add(lblHargaItem);

                    // QuantityBox (tombol -, 1, +)
                    QuantityBox keranjangQtyBox = new QuantityBox();
                    keranjangQtyBox.Minimum = 0;
                    keranjangQtyBox.Maximum = 200;
                    keranjangQtyBox.Value = qty; // Set nilai QuantityBox sesuai kuantitas di keranjang
                    keranjangQtyBox.Location = new Point(itemPictureBox.Right + 10, lblNamaProdukKeranjang.Bottom + 30);
                    keranjangQtyBox.Size = new Size(100, 25);
                    keranjangQtyBox.Tag = item.IdBrownies; // Simpan ID produk sebagai Tag

                    // Event ValueChanged untuk QuantityBox di SIDEBAR KERANJANG
                    keranjangQtyBox.ValueChanged += (s, ev) =>
                    {
                        QuantityBox senderQtyBox = s as QuantityBox;
                        int changedId = (int)senderQtyBox.Tag;
                        int changedQty = senderQtyBox.Value;

                        // Update data _quantityKeranjang dan _keranjangItems
                        if (changedQty > 0)
                        {
                            _quantityKeranjang[changedId] = changedQty;
                            // Pastikan item ada di _keranjangItems jika baru ditambahkan dari sidebar (jarang terjadi karena umumnya dari LoadProdukData)
                            if (!_keranjangItems.Any(b => b.IdBrownies == changedId))
                            {
                                var addedBrownies = _dbcontext.Brownies.FirstOrDefault(b => b.IdBrownies == changedId);
                                if (addedBrownies != null) _keranjangItems.Add(addedBrownies);
                            }
                        }
                        else // Kuantitas menjadi 0, hapus item dari keranjang
                        {
                            _keranjangItems.RemoveAll(b => b.IdBrownies == changedId); // Hapus dari daftar Browny
                            _quantityKeranjang.Remove(changedId); // Hapus dari dictionary kuantitas
                        }

                        // PENTING: Update QuantityBox di PRODUK LAYOUT PANEL (sisi kiri) juga!
                        // Ini memastikan sinkronisasi antara kuantitas di sidebar dan daftar produk utama
                        if (_quantityControls.ContainsKey(changedId))
                        {
                            _quantityControls[changedId].Value = changedQty;
                        }

                        // Refresh seluruh sidebar keranjang setelah perubahan
                        UpdateKeranjangSideBar();
                    };
                    itemKeranjangPanel.Controls.Add(keranjangQtyBox);

                    // Tombol Hapus (ikon tempat sampah)
                    Button btnHapus = new Button();
                    string trashIconPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "trash_icon.png");
                    if (File.Exists(trashIconPath))
                    {
                        btnHapus.BackgroundImage = Image.FromFile(trashIconPath);
                    }
                    else
                    {
                        Console.WriteLine($"Trash icon not found: {trashIconPath}");
                    }
                    btnHapus.BackgroundImageLayout = ImageLayout.Zoom;
                    btnHapus.Size = new Size(24, 24);
                    btnHapus.Location = new Point(itemKeranjangPanel.Width - btnHapus.Width - 10, keranjangQtyBox.Bottom + 10);
                    btnHapus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                    btnHapus.FlatStyle = FlatStyle.Flat;
                    btnHapus.FlatAppearance.BorderSize = 0;
                    btnHapus.BackColor = Color.Transparent;
                    btnHapus.Cursor = Cursors.Hand;
                    btnHapus.Tag = item.IdBrownies; // Simpan ID produk untuk identifikasi

                    // Event Click untuk Tombol Hapus
                    btnHapus.Click += (s, ev) =>
                    {
                        int idProdukHapus = (int)((Button)s).Tag;

                        // Hapus dari data keranjang statis
                        _keranjangItems.RemoveAll(b => b.IdBrownies == idProdukHapus);
                        _quantityKeranjang.Remove(idProdukHapus);

                        // PENTING: Reset QuantityBox di PRODUK LAYOUT PANEL (sisi kiri) menjadi 0
                        if (_quantityControls.ContainsKey(idProdukHapus))
                        {
                            _quantityControls[idProdukHapus].Value = 0;
                        }

                        // Refresh seluruh sidebar keranjang setelah penghapusan
                        UpdateKeranjangSideBar();
                    };
                    itemKeranjangPanel.Controls.Add(btnHapus);

                    // Tambahkan panel item ke FlowLayoutPanel di sidebar
                    flowPanelKeranjangHostItems.Controls.Add(itemKeranjangPanel);

                    // Hitung subtotal
                    subtotal += (item.HargaBrownies * qty);
                }
            }
            // Akhir Langkah 11

            // Hitung dan Perbarui Label Ringkasan
            decimal pajak = subtotal * pajakrate;
            decimal total = subtotal + pajak + ongkir;

            UpdateKeranjangSummaryLabels(subtotal, pajak, ongkir, total);
        }
    }
}
