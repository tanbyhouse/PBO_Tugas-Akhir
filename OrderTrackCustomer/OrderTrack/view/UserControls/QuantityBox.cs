using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderTrack.view.UserControls
{
    public partial class QuantityBox : UserControl
    {
        public event EventHandler ValueChanged;
        public int Minimum { get; set; } = 0;
        public int Maximum { get; set; } = 200;

        public int Value
        {
            get => int.Parse(lblValue.Text);
            set
            {
                int val = Math.Max(Minimum, Math.Min(Maximum, value));
                lblValue.Text = val.ToString();
                btnMinus.Enabled = val > Minimum;
                btnPlus.Enabled = val < Maximum;
            }
        }
        public QuantityBox()
        {
            InitializeComponent();
            Value = 0;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (Value > Minimum)
            {
                Value--;
                ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (Value < Maximum)
            {
                Value++;
                ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
