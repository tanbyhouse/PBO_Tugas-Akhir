namespace OrderTrack.view.UserControls
{
    partial class UC_confirmName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_confirmName));
            nameconfirmPanel = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnNext = new Button();
            btnBack = new Button();
            confirmNameBox = new TextBox();
            label1 = new Label();
            nameconfirmPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nameconfirmPanel
            // 
            nameconfirmPanel.BackColor = Color.FromArgb(232, 227, 207);
            nameconfirmPanel.Controls.Add(label2);
            nameconfirmPanel.Controls.Add(pictureBox1);
            nameconfirmPanel.Controls.Add(btnNext);
            nameconfirmPanel.Controls.Add(btnBack);
            nameconfirmPanel.Controls.Add(confirmNameBox);
            nameconfirmPanel.Controls.Add(label1);
            nameconfirmPanel.Dock = DockStyle.Left;
            nameconfirmPanel.Location = new Point(0, 0);
            nameconfirmPanel.Margin = new Padding(3, 2, 3, 2);
            nameconfirmPanel.Name = "nameconfirmPanel";
            nameconfirmPanel.Size = new Size(453, 338);
            nameconfirmPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gilroy-Medium", 10F);
            label2.ForeColor = Color.FromArgb(77, 59, 47);
            label2.Location = new Point(153, 90);
            label2.Name = "label2";
            label2.Size = new Size(232, 85);
            label2.TabIndex = 5;
            label2.Text = "Haloo👋 Broni di sini akan bantu\nmengirim pesanan kamu ke owner.\n\nKamu mau beli brownies\natas nama siapa nih?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(77, 59, 47);
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
            // confirmNameBox
            // 
            confirmNameBox.BackColor = Color.FromArgb(215, 206, 191);
            confirmNameBox.BorderStyle = BorderStyle.None;
            confirmNameBox.CharacterCasing = CharacterCasing.Upper;
            confirmNameBox.Font = new Font("Gilroy-Bold", 14F);
            confirmNameBox.ForeColor = Color.FromArgb(77, 59, 47);
            confirmNameBox.Location = new Point(33, 224);
            confirmNameBox.Margin = new Padding(3, 2, 3, 2);
            confirmNameBox.Multiline = true;
            confirmNameBox.Name = "confirmNameBox";
            confirmNameBox.PlaceholderText = "NAMA";
            confirmNameBox.Size = new Size(371, 35);
            confirmNameBox.TabIndex = 1;
            confirmNameBox.Text = "NAMA";
            confirmNameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(77, 59, 47);
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 0;
            label1.Text = "Checkout";
            // 
            // UC_confirmName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(nameconfirmPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_confirmName";
            Size = new Size(700, 338);
            nameconfirmPanel.ResumeLayout(false);
            nameconfirmPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel nameconfirmPanel;
        private Button btnNext;
        private Button btnBack;
        private TextBox confirmNameBox;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
