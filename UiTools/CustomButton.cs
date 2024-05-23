using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace BurakT_ATM.UiTools.CustomButton
{
    [DefaultEvent("Click")]
    public partial class CustomButton : UserControl
    {
        private Color cl0 = Color.Blue, cl1 = Color.Orange;
        private int wh = 20;
        private float ang = 45;
        private Timer t = new System.Windows.Forms.Timer();
        private string txt = "I'm custom button";
        private Color originalColor; // Original background color
        private bool isMouseOver = false;
        private Color borderColor = Color.White;

        public CustomButton()
        {
            DoubleBuffered = true;
            t.Interval = 60;
            t.Tick += (s, e) => { Angle = Angle % 360 + 1; };
            t.Start();
            ForeColor = Color.White;

            // Event handlers for mouse enter and leave
            this.MouseEnter += CustomButtonMouseEnter;
            this.MouseLeave += CustomButtonMouseLeave;
        }

        public float Angle
        {
            get { return ang; }
            set { ang = value; Invalidate(); }
        }

        //curvy edge 
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(new Rectangle(0, 0, wh, wh), 180, 90);
            gp.AddArc(new Rectangle(Width - wh, 0, wh, wh), -90, 90);
            gp.AddArc(new Rectangle(Width - wh, Height - wh, wh, wh), 0, 90);
            gp.AddArc(new Rectangle(0, Height - wh, wh, wh), 90, 90);
            gp.CloseFigure();

            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle, cl0, cl1, ang), gp);
            e.Graphics.DrawString(txt, Font, new SolidBrush(ForeColor), ClientRectangle, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });

            //mouse action with button
            if (isMouseOver)
            {
                using (Pen borderPen = new Pen(borderColor, 2))
                {
                    e.Graphics.DrawPath(borderPen, gp);
                }
            }
            base.OnPaint(e);
        }

        public int BorderRadius
        {
            get { return wh; }
            set { wh = value; Invalidate(); }
        }

        public Color Color0
        {
            get { return cl0; }
            set { cl0 = value; Invalidate(); }
        }

        public Color Color1
        {
            get { return cl1; }
            set { cl1 = value; Invalidate(); }
        }

        [Browsable(true)]
        public string ButtonText
        {
            get { return txt; }
            set { txt = value; Invalidate(); }
        }

        private void CustomButtonMouseEnter(object? sender, EventArgs e)
        {
            isMouseOver = true;
            Invalidate();
        }

        private void CustomButtonMouseLeave(object? sender, EventArgs e)
        {
            isMouseOver = false;
            Invalidate();
        }
    }
}
