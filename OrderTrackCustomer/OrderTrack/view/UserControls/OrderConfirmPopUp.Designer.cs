namespace OrderTrack.view.UserControls
{
    partial class OrderConfirmPopUp
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
            pnlOverlayBg = new OrderTrack.utils.TransparentPanel();
            pnlMessageBox = new Panel();
            btnOkay = new Button();
            pnlOverlayBg.SuspendLayout();
            SuspendLayout();
            // 
            // pnlOverlayBg
            // 
            pnlOverlayBg.BackColor = Color.FromArgb(150, 0, 0, 0);
            pnlOverlayBg.Controls.Add(pnlMessageBox);
            pnlOverlayBg.Controls.Add(btnOkay);
            pnlOverlayBg.Dock = DockStyle.Fill;
            pnlOverlayBg.Location = new Point(0, 0);
            pnlOverlayBg.Name = "pnlOverlayBg";
            pnlOverlayBg.Size = new Size(800, 450);
            pnlOverlayBg.TabIndex = 7;
            // 
            // pnlMessageBox
            // 
            pnlMessageBox.Location = new Point(289, 60);
            pnlMessageBox.Name = "pnlMessageBox";
            pnlMessageBox.Size = new Size(250, 125);
            pnlMessageBox.TabIndex = 1;
            // 
            // btnOkay
            // 
            btnOkay.Location = new Point(568, 286);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(94, 29);
            btnOkay.TabIndex = 0;
            btnOkay.Text = "Okay 👌";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += btnOkay_Click_1;
            // 
            // OrderConfirmPopUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            Controls.Add(pnlOverlayBg);
            Name = "OrderConfirmPopUp";
            Size = new Size(800, 450);
            pnlOverlayBg.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private utils.TransparentPanel pnlOverlayBg;
        private Button btnOkay;
        private Panel pnlMessageBox;
    }
}
