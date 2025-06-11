namespace OrderTrack.view.UserControls
{
    partial class RegisterUserControl
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
            btnRegister = new Button();
            panelSideBar = new Panel();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(361, 272);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(242, 55);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // panelSideBar
            // 
            panelSideBar.BackColor = Color.Black;
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.Location = new Point(0, 0);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(215, 450);
            panelSideBar.TabIndex = 1;
            // 
            // RegisterUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelSideBar);
            Controls.Add(btnRegister);
            Name = "RegisterUserControl";
            Size = new Size(800, 450);
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegister;
        private Panel panelSideBar;
    }
}
