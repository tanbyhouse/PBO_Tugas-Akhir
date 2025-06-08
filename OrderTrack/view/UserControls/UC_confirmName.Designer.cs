﻿namespace OrderTrack.view.UserControls
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
            nameconfirmPanel = new Panel();
            btnNext = new Button();
            btnBack = new Button();
            confirmNameBox = new TextBox();
            label1 = new Label();
            nameconfirmPanel.SuspendLayout();
            SuspendLayout();
            // 
            // nameconfirmPanel
            // 
            nameconfirmPanel.Controls.Add(btnNext);
            nameconfirmPanel.Controls.Add(btnBack);
            nameconfirmPanel.Controls.Add(confirmNameBox);
            nameconfirmPanel.Controls.Add(label1);
            nameconfirmPanel.Dock = DockStyle.Left;
            nameconfirmPanel.Location = new Point(0, 0);
            nameconfirmPanel.Name = "nameconfirmPanel";
            nameconfirmPanel.Size = new Size(438, 450);
            nameconfirmPanel.TabIndex = 0;
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
            // confirmNameBox
            // 
            confirmNameBox.Location = new Point(87, 246);
            confirmNameBox.Multiline = true;
            confirmNameBox.Name = "confirmNameBox";
            confirmNameBox.Size = new Size(271, 34);
            confirmNameBox.TabIndex = 1;
            confirmNameBox.Text = "Nama";
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
            // UC_confirmName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(nameconfirmPanel);
            Name = "UC_confirmName";
            Size = new Size(800, 450);
            nameconfirmPanel.ResumeLayout(false);
            nameconfirmPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel nameconfirmPanel;
        private Button btnNext;
        private Button btnBack;
        private TextBox confirmNameBox;
        private Label label1;
    }
}
