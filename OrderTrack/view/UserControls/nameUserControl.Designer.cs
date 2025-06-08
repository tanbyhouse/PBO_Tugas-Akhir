namespace OrderTrack.view.UserControls
{
    partial class nameUserControl
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
            namausrBox = new TextBox();
            btnBack = new Button();
            btnAlamat = new Button();
            SuspendLayout();
            // 
            // namausrBox
            // 
            namausrBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namausrBox.Location = new Point(233, 206);
            namausrBox.Multiline = true;
            namausrBox.Name = "namausrBox";
            namausrBox.Size = new Size(315, 51);
            namausrBox.TabIndex = 0;
            namausrBox.Text = "Nama";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(233, 263);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(157, 43);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAlamat
            // 
            btnAlamat.Location = new Point(396, 263);
            btnAlamat.Name = "btnAlamat";
            btnAlamat.Size = new Size(152, 43);
            btnAlamat.TabIndex = 2;
            btnAlamat.Text = "Next";
            btnAlamat.UseVisualStyleBackColor = true;
            btnAlamat.Click += btnAlamat_Click;
            // 
            // nameUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAlamat);
            Controls.Add(btnBack);
            Controls.Add(namausrBox);
            Name = "nameUserControl";
            Size = new Size(800, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox namausrBox;
        private Button btnBack;
        private Button btnAlamat;
    }
}
