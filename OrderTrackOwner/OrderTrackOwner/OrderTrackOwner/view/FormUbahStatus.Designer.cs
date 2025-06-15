using OrderTrackOwner.Data.Context_s;

namespace OrderTrackOwner.view
{
    partial class FormPilihStatus
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(30, 30);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(200, 28);
            this.comboBoxStatus.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(240, 30);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 29);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormPilihStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 100);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.comboBoxStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPilihStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pilih Status Pesanan";
            this.Load += new System.EventHandler(this.FormPilihStatus_Load);
            this.ResumeLayout(false);
        }

        private void FormPilihStatus_Load(object sender, EventArgs e)
        {
            comboBoxStatus.DataSource = Enum.GetValues(typeof(StatusPesanan));
        }
        #endregion

        private ComboBox comboBoxStatus;
        private Button btnOK;
    }
}