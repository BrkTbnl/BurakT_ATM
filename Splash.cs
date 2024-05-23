using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurakT_ATM
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int starting = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starting += 20;
            Myprogress.Value = starting;
            percentage.Text = starting + "%";
            if (Myprogress.Value == 100) 
            {
                Myprogress.Value = 0;
                timer1.Stop();
                Login log = new Login();
                this.Hide();
                log.Show();
            }
        }
    }
}
