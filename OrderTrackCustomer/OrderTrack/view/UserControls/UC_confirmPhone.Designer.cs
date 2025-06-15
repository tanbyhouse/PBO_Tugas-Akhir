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
            pictureBox2 = new PictureBox();
            btnNext = new Button();
            btnBack = new Button();
            confirmPhoneBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            phoneconfirmPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // phoneconfirmPanel
            // 
            phoneconfirmPanel.BackColor = Color.FromArgb(232, 227, 207);
            phoneconfirmPanel.Controls.Add(pictureBox2);
            phoneconfirmPanel.Controls.Add(btnNext);
            phoneconfirmPanel.Controls.Add(btnBack);
            phoneconfirmPanel.Controls.Add(confirmPhoneBox);
            phoneconfirmPanel.Controls.Add(label2);
            phoneconfirmPanel.Controls.Add(label1);
            phoneconfirmPanel.Controls.Add(pictureBox1);
            phoneconfirmPanel.Dock = DockStyle.Fill;
            phoneconfirmPanel.Location = new Point(0, 0);
            phoneconfirmPanel.Name = "phoneconfirmPanel";
            phoneconfirmPanel.Size = new Size(800, 451);
            phoneconfirmPanel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(482, -132);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(532, 651);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(77, 59, 47);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Microsoft Sans Serif", 10F);
            btnNext.ForeColor = Color.FromArgb(232, 227, 207);
            btnNext.Location = new Point(382, 363);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 47);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click_1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Tan;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft Sans Serif", 10F);
            btnBack.Location = new Point(38, 363);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 47);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // confirmPhoneBox
            // 
            confirmPhoneBox.BackColor = Color.FromArgb(215, 206, 191);
            confirmPhoneBox.BorderStyle = BorderStyle.None;
            confirmPhoneBox.Font = new Font("Microsoft Sans Serif", 14F);
            confirmPhoneBox.ForeColor = Color.FromArgb(77, 59, 47);
            confirmPhoneBox.Location = new Point(38, 299);
            confirmPhoneBox.Multiline = true;
            confirmPhoneBox.Name = "confirmPhoneBox";
            confirmPhoneBox.PlaceholderText = "Nomor HP";
            confirmPhoneBox.Size = new Size(424, 47);
            confirmPhoneBox.TabIndex = 1;
            confirmPhoneBox.Text = "Nomor HP";
            confirmPhoneBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(77, 59, 47);
            label2.Location = new Point(38, 16);
            label2.Name = "label2";
            label2.Size = new Size(171, 40);
            label2.TabIndex = 4;
            label2.Text = "Checkout";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = Color.FromArgb(77, 59, 47);
            label1.Location = new Point(175, 120);
            label1.Name = "label1";
            label1.Size = new Size(288, 100);
            label1.TabIndex = 7;
            label1.Text = "Sip👍 Satu lagi nih!\n\nBiar lebih mudah dihubungi\nkalau ada yang perlu dikonfirmasi, \nkasih tau nomor HP kamu juga dongg";
            label1.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 108);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // UC_confirmPhone
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(phoneconfirmPanel);
            Name = "UC_confirmPhone";
            Size = new Size(800, 451);
            phoneconfirmPanel.ResumeLayout(false);
            phoneconfirmPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel phoneconfirmPanel;
        private Button btnBack;
        private TextBox confirmPhoneBox;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnNext;
    }
}
