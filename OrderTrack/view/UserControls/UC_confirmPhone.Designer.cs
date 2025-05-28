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
            phoneconfirmPanel = new Panel();
            btnNext = new Button();
            btnBack = new Button();
            confirmPhoneBox = new TextBox();
            label1 = new Label();
            phoneconfirmPanel.SuspendLayout();
            SuspendLayout();
            // 
            // phoneconfirmPanel
            // 
            phoneconfirmPanel.Controls.Add(btnNext);
            phoneconfirmPanel.Controls.Add(btnBack);
            phoneconfirmPanel.Controls.Add(confirmPhoneBox);
            phoneconfirmPanel.Controls.Add(label1);
            phoneconfirmPanel.Dock = DockStyle.Left;
            phoneconfirmPanel.Location = new Point(0, 0);
            phoneconfirmPanel.Name = "phoneconfirmPanel";
            phoneconfirmPanel.Size = new Size(438, 450);
            phoneconfirmPanel.TabIndex = 2;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(264, 286);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(87, 286);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // confirmPhoneBox
            // 
            confirmPhoneBox.Location = new Point(87, 246);
            confirmPhoneBox.Multiline = true;
            confirmPhoneBox.Name = "confirmPhoneBox";
            confirmPhoneBox.Size = new Size(271, 34);
            confirmPhoneBox.TabIndex = 1;
            confirmPhoneBox.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 32);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Checkout";
            // 
            // UC_confirmPhone
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(phoneconfirmPanel);
            Name = "UC_confirmPhone";
            Size = new Size(800, 450);
            phoneconfirmPanel.ResumeLayout(false);
            phoneconfirmPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel phoneconfirmPanel;
        private Button btnNext;
        private Button btnBack;
        private TextBox confirmPhoneBox;
        private Label label1;
    }
}
