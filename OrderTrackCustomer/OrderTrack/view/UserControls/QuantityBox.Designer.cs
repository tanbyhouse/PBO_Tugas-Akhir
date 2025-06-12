namespace OrderTrack.view.UserControls
{
    partial class QuantityBox
    {
        private Button btnMinus;
        private Button btnPlus;
        private Label lblValue;

        private void InitializeComponent()
        {
            btnMinus = new Button();
            btnPlus = new Button();
            lblValue = new Label();
            SuspendLayout();

            // btnMinus
            btnMinus.Dock = DockStyle.Left;
            btnMinus.FlatAppearance.BorderColor = Color.Tan;
            btnMinus.Font = new Font("Gilroy-Medium", 10F);
            btnMinus.ForeColor = Color.FromArgb(77, 59, 47);
            btnMinus.Location = new Point(0, 0);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(30, 30);
            btnMinus.TabIndex = 2;
            btnMinus.Text = "-";
            btnMinus.Click += btnMinus_Click;

            // btnPlus
            btnPlus.Dock = DockStyle.Right;
            btnPlus.FlatAppearance.BorderColor = Color.Tan;
            btnPlus.Font = new Font("Gilroy-Medium", 10F);
            btnPlus.ForeColor = Color.FromArgb(77, 59, 47);
            btnPlus.Location = new Point(125, 0);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(30, 30);
            btnPlus.TabIndex = 1;
            btnPlus.Text = "+";
            btnPlus.Click += btnPlus_Click;

            // label Value
            lblValue.Dock = DockStyle.Fill;
            lblValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblValue.Location = new Point(30, 0);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(95, 30);
            lblValue.TabIndex = 0;
            //lblValue.Text = "0";
            lblValue.TextAlign = ContentAlignment.MiddleCenter;

            // QuantityBox
            Controls.Add(lblValue);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Name = "QuantityBox";
            Size = new Size(155, 30);
            ResumeLayout(false);
        }
    }
}
