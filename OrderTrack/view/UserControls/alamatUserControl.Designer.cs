namespace OrderTrack.view.UserControls
{
    partial class alamatUserControl
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
            textBox1 = new TextBox();
            btnAlamat = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(233, 206);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 51);
            textBox1.TabIndex = 0;
            textBox1.Text = "Alamat";
            // 
            // btnAlamat
            // 
            btnAlamat.Location = new Point(396, 263);
            btnAlamat.Name = "btnAlamat";
            btnAlamat.Size = new Size(152, 43);
            btnAlamat.TabIndex = 4;
            btnAlamat.Text = "Next";
            btnAlamat.UseVisualStyleBackColor = true;
            btnAlamat.Click += btnAlamat_Click;
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
            // alamatUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAlamat);
            Controls.Add(btnBack);
            Controls.Add(textBox1);
            Name = "alamatUserControl";
            Size = new Size(800, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnAlamat;
        private Button btnBack;
    }
}
