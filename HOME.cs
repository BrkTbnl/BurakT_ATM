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
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            HOME hOME = new HOME();
            hOME.Show();
            this.Hide();
        }

        //Balance
        private void button6_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            this.Hide();
            balance.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Home page Acc number
        public static String AccNumber;
        private void HOME_Load(object sender, EventArgs e)
            
        {
            AccNumlbl.Text = "Account Number: " + Login.AccNumber;
            AccNumber = Login.AccNumber;

        }

        private void AccNumBl_Click(object sender, EventArgs e)
        {

        }
    }
}
