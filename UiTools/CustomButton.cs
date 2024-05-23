using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace BurakT_ATM.UiTools.CustomButton
{
    [DefaultEvent("Click")]

    public partial class CustomButton : UserControl
    {
        Color cl0 = Color.Blue, cl1 = Color.Orange;
        int wh = 20;
        float ang = 45;
        Timer t = new Timer();
        private string txt = "Im custom button";
        private Color originalColor; // Orjinal arka plan rengini saklamak için

        public CustomButton()
        {
            DoubleBuffered = true;
            t.Interval = 60;
            t.Start();
            t.Tick += (s, e) => { Angle = Angle % 360 + 1; };
            ForeColor = Color.White;

            // Tıklandığında olayı dinlemek için EventHandler ekleyelim
            this.Click += CustomButton_Click;
        }

        public float Angle
        {
            get { return ang; }
            set { ang = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(new Rectangle(0, 0, wh, wh), 180, 90);
            gp.AddArc(new Rectangle(Width - wh, 0, wh, wh), -90, 90);
            gp.AddArc(new Rectangle(Width - wh, Height - wh, wh, wh), 0, 90);
            gp.AddArc(new Rectangle(0, Height - wh, wh, wh), 90, 90);

            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle, cl0, cl1, ang), gp);
            e.Graphics.DrawString(txt, Font, new SolidBrush(ForeColor), ClientRectangle, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
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

        private void CustomButton_Click(object sender, EventArgs e)
        {
            // Buton tıklandığında arka plan rengini geçici olarak değiştirelim
            originalColor = BackColor; // Orijinal rengi sakla
            BackColor = Color.LightGray; // Geçici olarak arka plan rengini değiştir
            Refresh(); // Yenile
            // 100 ms sonra arka plan rengini eski haline getir
            Timer resetColorTimer = new Timer();
            resetColorTimer.Interval = 100;
            resetColorTimer.Tick += (s, evt) =>
            {
                BackColor = originalColor;
                resetColorTimer.Stop(); // Timer'ı durdur
            };
            resetColorTimer.Start();
        }
    }
}
