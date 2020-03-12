using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public class CUVProgressBar : ProgressBar
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x04;
                return cp;
            }
        }

        public CUVProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            rec.Height = (int)(rec.Height * ((double)Value / Maximum)) ;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            SolidBrush brush = new SolidBrush(BarraColor);
            e.Graphics.FillRectangle(brush, 1, (this.Height - rec.Height),  rec.Width-2,rec.Height);
        }

        private Color barraColor;

        public Color BarraColor
        {
            get { return barraColor; }
            set { barraColor = value; }
        }
      
    }
}
