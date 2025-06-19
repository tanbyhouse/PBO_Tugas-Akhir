namespace OrderTrack.view.UserControls
{
    partial class UC_keranjang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_keranjang));
            mainLayoutPanel = new TableLayoutPanel();
            pnlContainer = new Panel();
            flowPanelKeranjangItemsHost = new FlowLayoutPanel();
            emptyPanel = new Panel();
            pictureBox1 = new PictureBox();
            lblEmpty = new Label();
            pnlButton = new Panel();
            btnBack = new Button();
            btnCheckout = new Button();
            mainLayoutPanel.SuspendLayout();
            pnlContainer.SuspendLayout();
            flowPanelKeranjangItemsHost.SuspendLayout();
            emptyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlButton.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            mainLayoutPanel.BackColor = Color.Transparent;
            mainLayoutPanel.ColumnCount = 1;
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            mainLayoutPanel.Controls.Add(pnlContainer, 0, 0);
            mainLayoutPanel.Dock = DockStyle.Left;
            mainLayoutPanel.Location = new Point(0, 0);
            mainLayoutPanel.Name = "mainLayoutPanel";
            mainLayoutPanel.RowCount = 1;
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayoutPanel.Size = new Size(558, 450);
            mainLayoutPanel.TabIndex = 2;
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(flowPanelKeranjangItemsHost);
            pnlContainer.Controls.Add(pnlButton);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(3, 3);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(552, 444);
            pnlContainer.TabIndex = 3;
            // 
            // flowPanelKeranjangItemsHost
            // 
            flowPanelKeranjangItemsHost.Controls.Add(emptyPanel);
            flowPanelKeranjangItemsHost.Dock = DockStyle.Fill;
            flowPanelKeranjangItemsHost.Location = new Point(0, 0);
            flowPanelKeranjangItemsHost.Name = "flowPanelKeranjangItemsHost";
            flowPanelKeranjangItemsHost.Size = new Size(552, 381);
            flowPanelKeranjangItemsHost.TabIndex = 4;
            // 
            // emptyPanel
            // 
            emptyPanel.BackColor = Color.Transparent;
            emptyPanel.Controls.Add(pictureBox1);
            emptyPanel.Controls.Add(lblEmpty);
            emptyPanel.Enabled = false;
            emptyPanel.Location = new Point(3, 3);
            emptyPanel.Name = "emptyPanel";
            emptyPanel.Size = new Size(551, 379);
            emptyPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 133);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblEmpty
            // 
            lblEmpty.AutoSize = true;
            lblEmpty.BackColor = Color.FromArgb(232, 227, 207);
            lblEmpty.FlatStyle = FlatStyle.Flat;
            lblEmpty.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmpty.Location = new Point(139, 133);
            lblEmpty.Name = "lblEmpty";
            lblEmpty.Size = new Size(371, 44);
            lblEmpty.TabIndex = 0;
            lblEmpty.Text = "Keranjangnya Masih Kosong Nih 😔\n Jangan lupa cek produk di daftar menu ya😁";
            lblEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlButton
            // 
            pnlButton.BackColor = Color.Transparent;
            pnlButton.Controls.Add(btnBack);
            pnlButton.Controls.Add(btnCheckout);
            pnlButton.Dock = DockStyle.Bottom;
            pnlButton.Location = new Point(0, 381);
            pnlButton.Name = "pnlButton";
            pnlButton.Size = new Size(552, 63);
            pnlButton.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom;
            btnBack.BackColor = Color.FromArgb(232, 227, 207);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft Sans Serif", 10F);
            btnBack.ForeColor = Color.FromArgb(77, 59, 47);
            btnBack.Location = new Point(26, 7);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(218, 46);
            btnBack.TabIndex = 2;
            btnBack.Text = "Daftar Menu";
            btnBack.UseMnemonic = false;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // btnCheckout
            // 
            btnCheckout.Anchor = AnchorStyles.Bottom;
            btnCheckout.BackColor = Color.FromArgb(232, 227, 207);
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Microsoft Sans Serif", 10F);
            btnCheckout.ForeColor = Color.FromArgb(77, 59, 47);
            btnCheckout.Location = new Point(294, 7);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(218, 46);
            btnCheckout.TabIndex = 1;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseMnemonic = false;
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click_1;
            // 
            // UC_keranjang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(77, 59, 47);
            Controls.Add(mainLayoutPanel);
            Name = "UC_keranjang";
            Size = new Size(800, 450);
            mainLayoutPanel.ResumeLayout(false);
            pnlContainer.ResumeLayout(false);
            flowPanelKeranjangItemsHost.ResumeLayout(false);
            emptyPanel.ResumeLayout(false);
            emptyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel mainLayoutPanel;
        private Panel pnlContainer;
        private Panel pnlButton;
        private Button btnBack;
        private Button btnCheckout;
        private FlowLayoutPanel flowPanelKeranjangItemsHost;
        private Panel emptyPanel;
        private Label lblEmpty;
        private PictureBox pictureBox1;
    }
}
