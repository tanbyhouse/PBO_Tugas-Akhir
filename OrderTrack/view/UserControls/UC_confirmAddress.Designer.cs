namespace OrderTrack.view.UserControls
{
    partial class UC_confirmAddress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_confirmAddress));
            addressconfirmPanel = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnNext = new Button();
            btnBack = new Button();
            confirmAddressBox = new TextBox();
            addressconfirmPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // addressconfirmPanel
            // 
            addressconfirmPanel.BackColor = Color.FromArgb(232, 227, 207);
            addressconfirmPanel.Controls.Add(label1);
            addressconfirmPanel.Controls.Add(pictureBox1);
            addressconfirmPanel.Controls.Add(label2);
            addressconfirmPanel.Controls.Add(btnNext);
            addressconfirmPanel.Controls.Add(btnBack);
            addressconfirmPanel.Controls.Add(confirmAddressBox);
            addressconfirmPanel.Dock = DockStyle.Left;
            addressconfirmPanel.Location = new Point(0, 0);
            addressconfirmPanel.Margin = new Padding(3, 2, 3, 2);
            addressconfirmPanel.Name = "addressconfirmPanel";
            addressconfirmPanel.Size = new Size(453, 338);
            addressconfirmPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gilroy-Medium", 10F);
            label1.ForeColor = Color.FromArgb(77, 59, 47);
            label1.Location = new Point(153, 90);
            label1.Name = "label1";
            label1.Size = new Size(218, 68);
            label1.TabIndex = 6;
            label1.Text = "Okeii, browniesnya mau dikirim \nke mana nih? \n\nTuliskan alamat lengkapnya yaa";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica", 20F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(77, 59, 47);
            label2.Location = new Point(19, 12);
            label2.Name = "label2";
            label2.Size = new Size(139, 32);
            label2.TabIndex = 4;
            label2.Text = "Checkout";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(77, 59, 47);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Gilroy-Bold", 10F);
            btnNext.ForeColor = Color.FromArgb(232, 227, 207);
            btnNext.Location = new Point(334, 288);
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
            btnBack.Location = new Point(33, 288);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(70, 35);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // confirmAddressBox
            // 
            confirmAddressBox.BackColor = Color.FromArgb(215, 206, 191);
            confirmAddressBox.BorderStyle = BorderStyle.None;
            confirmAddressBox.Font = new Font("Gilroy-Medium", 10F);
            confirmAddressBox.Location = new Point(33, 219);
            confirmAddressBox.Margin = new Padding(3, 2, 3, 2);
            confirmAddressBox.Multiline = true;
            confirmAddressBox.Name = "confirmAddressBox";
            confirmAddressBox.Size = new Size(371, 60);
            confirmAddressBox.TabIndex = 1;
            confirmAddressBox.Text = "Alamat";
            // 
            // UC_confirmAddress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addressconfirmPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_confirmAddress";
            Size = new Size(700, 338);
            addressconfirmPanel.ResumeLayout(false);
            addressconfirmPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel addressconfirmPanel;
        private Button btnNext;
        private Button btnBack;
        private TextBox confirmAddressBox;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
