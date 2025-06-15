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
            mainLayoutPanel = new TableLayoutPanel();
            pnlContainer = new Panel();
            flowPanelKeranjangItemsHost = new FlowLayoutPanel();
            pnlButton = new Panel();
            btnBack = new Button();
            btnCheckout = new Button();
            mainLayoutPanel.SuspendLayout();
            pnlContainer.SuspendLayout();
            pnlButton.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            mainLayoutPanel.BackColor = Color.Transparent;
            mainLayoutPanel.ColumnCount = 2;
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            mainLayoutPanel.Controls.Add(pnlContainer, 0, 0);
            mainLayoutPanel.Dock = DockStyle.Fill;
            mainLayoutPanel.Location = new Point(0, 0);
            mainLayoutPanel.Name = "mainLayoutPanel";
            mainLayoutPanel.RowCount = 1;
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayoutPanel.Size = new Size(800, 450);
            mainLayoutPanel.TabIndex = 2;
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(flowPanelKeranjangItemsHost);
            pnlContainer.Controls.Add(pnlButton);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(3, 3);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(554, 444);
            pnlContainer.TabIndex = 3;
            // 
            // flowPanelKeranjangItemsHost
            // 
            flowPanelKeranjangItemsHost.Dock = DockStyle.Fill;
            flowPanelKeranjangItemsHost.Location = new Point(0, 0);
            flowPanelKeranjangItemsHost.Name = "flowPanelKeranjangItemsHost";
            flowPanelKeranjangItemsHost.Size = new Size(554, 381);
            flowPanelKeranjangItemsHost.TabIndex = 4;
            // 
            // pnlButton
            // 
            pnlButton.BackColor = Color.Transparent;
            pnlButton.Controls.Add(btnBack);
            pnlButton.Controls.Add(btnCheckout);
            pnlButton.Dock = DockStyle.Bottom;
            pnlButton.Location = new Point(0, 381);
            pnlButton.Name = "pnlButton";
            pnlButton.Size = new Size(554, 63);
            pnlButton.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom;
            btnBack.BackColor = Color.FromArgb(232, 227, 207);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft Sans Serif", 10F);
            btnBack.ForeColor = Color.FromArgb(77, 59, 47);
            btnBack.Location = new Point(27, 7);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(218, 46);
            btnBack.TabIndex = 2;
            btnBack.Text = "Kembali";
            btnBack.UseMnemonic = false;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            btnCheckout.Anchor = AnchorStyles.Bottom;
            btnCheckout.BackColor = Color.FromArgb(232, 227, 207);
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Microsoft Sans Serif", 10F);
            btnCheckout.ForeColor = Color.FromArgb(77, 59, 47);
            btnCheckout.Location = new Point(295, 7);
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
    }
}
