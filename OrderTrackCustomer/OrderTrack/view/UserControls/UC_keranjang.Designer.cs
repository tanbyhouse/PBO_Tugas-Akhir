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
            PesananSaya_Panel = new Panel();
            PesananLabel = new Label();
            flowPanelKeranjangItems = new FlowLayoutPanel();
            Panel_RingkasanBayar = new Panel();
            layoutRingkasanBayar = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            PesananSaya_Panel.SuspendLayout();
            Panel_RingkasanBayar.SuspendLayout();
            layoutRingkasanBayar.SuspendLayout();
            SuspendLayout();
            // 
            // PesananSaya_Panel
            // 
            PesananSaya_Panel.Controls.Add(PesananLabel);
            PesananSaya_Panel.Dock = DockStyle.Top;
            PesananSaya_Panel.Location = new Point(0, 0);
            PesananSaya_Panel.Name = "PesananSaya_Panel";
            PesananSaya_Panel.Size = new Size(234, 91);
            PesananSaya_Panel.TabIndex = 0;
            // 
            // PesananLabel
            // 
            PesananLabel.AutoSize = true;
            PesananLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PesananLabel.Location = new Point(12, 27);
            PesananLabel.Name = "PesananLabel";
            PesananLabel.Size = new Size(151, 31);
            PesananLabel.TabIndex = 0;
            PesananLabel.Text = "Pesanan Saya";
            // 
            // flowPanelKeranjangItems
            // 
            flowPanelKeranjangItems.AutoScroll = true;
            flowPanelKeranjangItems.FlowDirection = FlowDirection.TopDown;
            flowPanelKeranjangItems.Location = new Point(0, 91);
            flowPanelKeranjangItems.Name = "flowPanelKeranjangItems";
            flowPanelKeranjangItems.Size = new Size(234, 353);
            flowPanelKeranjangItems.TabIndex = 1;
            // 
            // Panel_RingkasanBayar
            // 
            Panel_RingkasanBayar.Controls.Add(layoutRingkasanBayar);
            Panel_RingkasanBayar.Dock = DockStyle.Bottom;
            Panel_RingkasanBayar.Location = new Point(0, 329);
            Panel_RingkasanBayar.Name = "Panel_RingkasanBayar";
            Panel_RingkasanBayar.Size = new Size(234, 115);
            Panel_RingkasanBayar.TabIndex = 0;
            // 
            // layoutRingkasanBayar
            // 
            layoutRingkasanBayar.ColumnCount = 2;
            layoutRingkasanBayar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layoutRingkasanBayar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layoutRingkasanBayar.Controls.Add(label8, 1, 3);
            layoutRingkasanBayar.Controls.Add(label7, 0, 3);
            layoutRingkasanBayar.Controls.Add(label6, 1, 2);
            layoutRingkasanBayar.Controls.Add(label5, 0, 2);
            layoutRingkasanBayar.Controls.Add(label4, 1, 1);
            layoutRingkasanBayar.Controls.Add(label3, 0, 1);
            layoutRingkasanBayar.Controls.Add(label2, 1, 0);
            layoutRingkasanBayar.Controls.Add(label1, 0, 0);
            layoutRingkasanBayar.Dock = DockStyle.Bottom;
            layoutRingkasanBayar.Location = new Point(0, -1);
            layoutRingkasanBayar.Name = "layoutRingkasanBayar";
            layoutRingkasanBayar.RowCount = 4;
            layoutRingkasanBayar.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layoutRingkasanBayar.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layoutRingkasanBayar.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            layoutRingkasanBayar.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            layoutRingkasanBayar.Size = new Size(234, 116);
            layoutRingkasanBayar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Subtotal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Rp. 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 33);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "Pajak";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 33);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 3;
            label4.Text = "Rp. 0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 66);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 4;
            label5.Text = "Ongkos kirim";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(120, 66);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 5;
            label6.Text = "Rp. 0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 91);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 6;
            label7.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(120, 91);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 7;
            label8.Text = "Rp. 0";
            // 
            // UC_keranjang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Panel_RingkasanBayar);
            Controls.Add(flowPanelKeranjangItems);
            Controls.Add(PesananSaya_Panel);
            Name = "UC_keranjang";
            Size = new Size(234, 444);
            PesananSaya_Panel.ResumeLayout(false);
            PesananSaya_Panel.PerformLayout();
            Panel_RingkasanBayar.ResumeLayout(false);
            layoutRingkasanBayar.ResumeLayout(false);
            layoutRingkasanBayar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PesananSaya_Panel;
        private FlowLayoutPanel flowPanelKeranjangItems;
        private Panel Panel_RingkasanBayar;
        private TableLayoutPanel layoutRingkasanBayar;
        private Label PesananLabel;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
