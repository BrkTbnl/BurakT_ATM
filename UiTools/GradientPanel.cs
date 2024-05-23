using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurakT_ATM.UiTools
{
    public class GradientPanel : Panel
    {

        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }

        public float angle { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, TopColor, BottomColor, angle);
            Graphics g = e.Graphics;
            g.FillRectangle(brush, ClientRectangle);
            base.OnPaint(e);

        }

    }
}
