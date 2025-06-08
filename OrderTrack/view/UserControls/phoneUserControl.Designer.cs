namespace OrderTrack.view.UserControls
{
    partial class phoneUserControl
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
            phonenumberBox = new TextBox();
            btnProduct = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // phonenumberBox
            // 
            phonenumberBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phonenumberBox.Location = new Point(233, 206);
            phonenumberBox.Multiline = true;
            phonenumberBox.Name = "phonenumberBox";
            phonenumberBox.Size = new Size(315, 51);
            phonenumberBox.TabIndex = 0;
            phonenumberBox.Text = "PhoneNumber";
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(396, 263);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(152, 43);
            btnProduct.TabIndex = 4;
            btnProduct.Text = "Next";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(233, 263);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(157, 43);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // phoneUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnProduct);
            Controls.Add(btnBack);
            Controls.Add(phonenumberBox);
            Name = "phoneUserControl";
            Size = new Size(800, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox phonenumberBox;
        private Button btnProduct;
        private Button btnBack;
    }
}
