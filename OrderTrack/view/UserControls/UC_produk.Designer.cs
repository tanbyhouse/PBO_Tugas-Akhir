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
            btnMakeOrder = new Button();
            btnKeranjang = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(btnMakeOrder);
            panel1.Controls.Add(btnKeranjang);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 347);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 103);
            panel1.TabIndex = 0;
            // 
            // btnMakeOrder
            // 
            btnMakeOrder.ForeColor = SystemColors.ControlText;
            btnMakeOrder.Location = new Point(500, 36);
            btnMakeOrder.Name = "btnMakeOrder";
            btnMakeOrder.Size = new Size(138, 29);
            btnMakeOrder.TabIndex = 4;
            btnMakeOrder.Text = "Buat Pesanan";
            btnMakeOrder.UseVisualStyleBackColor = true;
            btnMakeOrder.Click += btnMakeOrder_Click;
            // 
            // btnKeranjang
            // 
            btnKeranjang.Location = new Point(175, 36);
            btnKeranjang.Name = "btnKeranjang";
            btnKeranjang.Size = new Size(94, 29);
            btnKeranjang.TabIndex = 1;
            btnKeranjang.Text = "Keranjang";
            btnKeranjang.UseVisualStyleBackColor = true;
            btnKeranjang.Click += btnKeranjang_Click;
            // 
            // UC_produk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UC_produk";
            Size = new Size(800, 450);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnKeranjang;
        private Button btnMakeOrder;
    }
}
