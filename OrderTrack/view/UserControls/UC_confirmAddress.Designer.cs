﻿namespace OrderTrack.view.UserControls
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
            addressconfirmPanel = new Panel();
            btnNext = new Button();
            btnBack = new Button();
            confirmAddressBox = new TextBox();
            label1 = new Label();
            addressconfirmPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addressconfirmPanel
            // 
            addressconfirmPanel.Controls.Add(btnNext);
            addressconfirmPanel.Controls.Add(btnBack);
            addressconfirmPanel.Controls.Add(confirmAddressBox);
            addressconfirmPanel.Controls.Add(label1);
            addressconfirmPanel.Dock = DockStyle.Left;
            addressconfirmPanel.Location = new Point(0, 0);
            addressconfirmPanel.Name = "addressconfirmPanel";
            addressconfirmPanel.Size = new Size(438, 450);
            addressconfirmPanel.TabIndex = 1;
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
            // confirmAddressBox
            // 
            confirmAddressBox.Location = new Point(87, 246);
            confirmAddressBox.Multiline = true;
            confirmAddressBox.Name = "confirmAddressBox";
            confirmAddressBox.Size = new Size(271, 34);
            confirmAddressBox.TabIndex = 1;
            confirmAddressBox.Text = "Alamat";
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
            // UC_confirmAddress
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addressconfirmPanel);
            Name = "UC_confirmAddress";
            Size = new Size(800, 450);
            addressconfirmPanel.ResumeLayout(false);
            addressconfirmPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel addressconfirmPanel;
        private Button btnNext;
        private Button btnBack;
        private TextBox confirmAddressBox;
        private Label label1;
    }
}
