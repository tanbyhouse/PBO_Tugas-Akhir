using System;
using System.Drawing;
using System.Drawing.Drawing2D; // Penting untuk GraphicsPath
using System.Windows.Forms;

namespace OrderTrack.utils
{
    public class RoundedPanel : Panel
    {
        private int _cornerRadius = 10;
        private Color _borderColor = Color.LightGray;
        private int _borderThickness = 1;

        public RoundedPanel()
        {
            // PENTING: Mengatur gaya kontrol untuk custom painting dan double buffering
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            this.UpdateStyles();
            this.BackColor = Color.Transparent; // Atur default BackColor di sini, tapi bisa di-override
        }

        public int CornerRadius
        {
            get { return _cornerRadius; }
            set
            {
                if (value < 0) value = 0;
                _cornerRadius = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderThickness
        {
            get { return _borderThickness; }
            set
            {
                if (value < 0) value = 0;
                _borderThickness = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // base.OnPaint(e); // <--- PASTIKAN BARIS INI DI-COMMENT ATAU DIHAPUS

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // Untuk gambar yang lebih halus

            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            float curveSize = _cornerRadius * 2F;
            // Handle cases where the panel is too small for the radius
            if (curveSize > rect.Width || curveSize > rect.Height)
            {
                // Fallback to regular rectangle if panel is smaller than curveSize
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    g.FillRectangle(brush, rect);
                }
                if (_borderThickness > 0)
                {
                    using (Pen pen = new Pen(this.BorderColor, this.BorderThickness)) // Gunakan properti BorderColor
                    {
                        g.DrawRectangle(pen, rect.X, rect.Y, rect.Width - 1, rect.Height - 1); // -1 untuk menggambar di dalam batas kontrol
                    }
                }
                return;
            }

            // Path untuk menggambar rounded rectangle
            using (GraphicsPath path = GetRoundedRectanglePath(rect, _cornerRadius))
            {
                // Mengisi background panel dengan warna yang ditentukan
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    g.FillPath(brush, path);
                }

                // Menggambar border (jika ketebalan > 0)
                if (_borderThickness > 0)
                {
                    using (Pen pen = new Pen(this.BorderColor, this.BorderThickness)) // Gunakan properti BorderColor
                    {
                        g.DrawPath(pen, path);
                    }
                }
            }
            // Penting: Memanggil base.OnPaintChildren agar kontrol anak digambar
            //base.OnPaintChildren(e);
            return;
        }

        // Helper method untuk membuat path rounded rectangle
        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            // Membuat arc dan garis untuk setiap sisi rectangle
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90); // Top-left
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90); // Top-right
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90); // Bottom-right
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90); // Bottom-left
            path.CloseFigure();
            return path;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate(); // Minta gambar ulang saat ukuran berubah
        }
    }
}