namespace OrderTrack.view.UserControls
{
    partial class UC_KeranjangConfirm
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
            checkoutButton = new Button();
            SuspendLayout();
            // 
            // checkoutButton
            // 
            checkoutButton.Location = new Point(596, 382);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(94, 29);
            checkoutButton.TabIndex = 0;
            checkoutButton.Text = "Checkout";
            checkoutButton.UseVisualStyleBackColor = true;
            checkoutButton.Click += checkoutButton_Click;
            // 
            // UC_KeranjangConfirm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkoutButton);
            Name = "UC_KeranjangConfirm";
            Size = new Size(800, 451);
            ResumeLayout(false);
        }

        #endregion

        private Button checkoutButton;
    }
}
