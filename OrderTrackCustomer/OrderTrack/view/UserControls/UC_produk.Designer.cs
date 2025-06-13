namespace OrderTrack.view.UserControls
{
    partial class UC_produk
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowPanel_product = new FlowLayoutPanel();
            uC_Keranjang = new UC_keranjang();
            btnMakeOrder = new Button();
            btnKeranjang = new Button();
            buttonPanel = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.SaddleBrown;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(flowPanel_product, 0, 0);
            tableLayoutPanel1.Controls.Add(uC_Keranjang, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowPanel_product
            // 
            flowPanel_product.AutoScroll = true;
            flowPanel_product.BackColor = Color.SaddleBrown;
            flowPanel_product.Location = new Point(3, 3);
            flowPanel_product.Name = "flowPanel_product";
            flowPanel_product.Size = new Size(497, 378);
            flowPanel_product.TabIndex = 0;
            // 
            // uC_Keranjang
            // 
            uC_Keranjang.Location = new Point(563, 3);
            uC_Keranjang.Name = "uC_Keranjang";
            uC_Keranjang.Size = new Size(234, 444);
            uC_Keranjang.TabIndex = 1;
            // 
            // btnMakeOrder
            // 
            btnMakeOrder.ForeColor = SystemColors.ControlText;
            btnMakeOrder.Location = new Point(212, 11);
            btnMakeOrder.Name = "btnMakeOrder";
            btnMakeOrder.Size = new Size(138, 29);
            btnMakeOrder.TabIndex = 4;
            btnMakeOrder.Text = "Buat Pesanan";
            btnMakeOrder.UseVisualStyleBackColor = true;
            btnMakeOrder.Click += btnMakeOrder_Click;
            // 
            // btnKeranjang
            // 
            btnKeranjang.Location = new Point(28, 11);
            btnKeranjang.Name = "btnKeranjang";
            btnKeranjang.Size = new Size(94, 29);
            btnKeranjang.TabIndex = 1;
            btnKeranjang.Text = "Keranjang";
            btnKeranjang.UseVisualStyleBackColor = true;
            btnKeranjang.Click += btnKeranjang_Click;
            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = Color.SaddleBrown;
            buttonPanel.Controls.Add(btnMakeOrder);
            buttonPanel.Controls.Add(btnKeranjang);
            buttonPanel.Location = new Point(61, 387);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(376, 49);
            buttonPanel.TabIndex = 1;
            // 
            // UC_produk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonPanel);
            Controls.Add(panel1);
            Name = "UC_produk";
            Size = new Size(800, 450);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnKeranjang;
        private Button btnMakeOrder;
        private Panel buttonPanel;
        private FlowLayoutPanel flowPanel_product;
        private TableLayoutPanel tableLayoutPanel1;
        private UC_keranjang uC_Keranjang;
    }
}
