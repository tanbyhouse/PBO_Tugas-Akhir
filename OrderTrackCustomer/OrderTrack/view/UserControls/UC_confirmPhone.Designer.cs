namespace OrderTrack.view.UserControls
{
    partial class UC_confirmPhone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_confirmPhone));
            phoneconfirmPanel = new Panel();
            btnNext = new Button();
            btnBack = new Button();
            confirmPhoneBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            phoneconfirmPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // phoneconfirmPanel
            // 
            phoneconfirmPanel.BackColor = Color.FromArgb(232, 227, 207);
            phoneconfirmPanel.Controls.Add(btnNext);
            phoneconfirmPanel.Controls.Add(btnBack);
            phoneconfirmPanel.Controls.Add(confirmPhoneBox);
            phoneconfirmPanel.Controls.Add(label2);
            phoneconfirmPanel.Controls.Add(label1);
            phoneconfirmPanel.Controls.Add(pictureBox1);
            phoneconfirmPanel.Dock = DockStyle.Left;
            phoneconfirmPanel.Location = new Point(0, 0);
            phoneconfirmPanel.Margin = new Padding(3, 2, 3, 2);
            phoneconfirmPanel.Name = "phoneconfirmPanel";
            phoneconfirmPanel.Size = new Size(453, 338);
            phoneconfirmPanel.TabIndex = 2;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(77, 59, 47);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Gilroy-Bold", 10F);
            btnNext.ForeColor = Color.FromArgb(232, 227, 207);
            btnNext.Location = new Point(334, 272);
            btnNext.Margin = new Padding(3, 2, 3, 2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(70, 35);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Tan;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Gilroy-Bold", 10F);
            btnBack.Location = new Point(33, 272);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(70, 35);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // confirmPhoneBox
            // 
            confirmPhoneBox.BackColor = Color.FromArgb(215, 206, 191);
            confirmPhoneBox.BorderStyle = BorderStyle.None;
            confirmPhoneBox.Font = new Font("Gilroy-Bold", 14F);
            confirmPhoneBox.ForeColor = Color.FromArgb(77, 59, 47);
            confirmPhoneBox.Location = new Point(33, 224);
            confirmPhoneBox.Margin = new Padding(3, 2, 3, 2);
            confirmPhoneBox.Multiline = true;
            confirmPhoneBox.Name = "confirmPhoneBox";
            confirmPhoneBox.PlaceholderText = "Nomor HP";
            confirmPhoneBox.Size = new Size(371, 35);
            confirmPhoneBox.TabIndex = 1;
            confirmPhoneBox.Text = "Nomor HP";
            confirmPhoneBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica", 20F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(77, 59, 47);
            label2.Location = new Point(33, 12);
            label2.Name = "label2";
            label2.Size = new Size(139, 32);
            label2.TabIndex = 4;
            label2.Text = "Checkout";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gilroy-Medium", 10F);
            label1.ForeColor = Color.FromArgb(77, 59, 47);
            label1.Location = new Point(153, 90);
            label1.Name = "label1";
            label1.Size = new Size(251, 85);
            label1.TabIndex = 7;
            label1.Text = "Sip👍 Satu lagi nih!\n\nBiar lebih mudah dihubungi\nkalau ada yang perlu dikonfirmasi, \nkasih tau nomor HP kamu juga dongg";
            label1.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // UC_confirmPhone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(phoneconfirmPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_confirmPhone";
            Size = new Size(700, 338);
            phoneconfirmPanel.ResumeLayout(false);
            phoneconfirmPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel phoneconfirmPanel;
        private Button btnNext;
        private Button btnBack;
        private TextBox confirmPhoneBox;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
