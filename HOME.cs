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

       

        //Balance
        private void button6_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            this.Hide();
            balance.Show();
        }
        //change password
        private void button5_Click(object sender, EventArgs e)
        {
            ChangePin pin = new ChangePin();
            pin.Show();
            this.Hide();
        }
        //ministatement
        private void button4_Click(object sender, EventArgs e)
        {
            ministatement ms = new ministatement();
            ms.Show();
            this.Hide();
        }
        //fast cash button
        private void button3_Click(object sender, EventArgs e)
        {
            FASTCASH fc = new FASTCASH();
            fc.Show();
            this.Hide();
        }
        //withdraw button
        private void button2_Click(object sender, EventArgs e)
        {
            withdraw wd = new withdraw();
            wd.Show();
            this.Hide();
        }
        //Deposit button
        private void button1_Click(object sender, EventArgs e)
        {
            Deposit dp = new Deposit();
            dp.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Home page Acc number
        public static String AccNumber;
        private void HOME_Load(object sender, EventArgs e)

        {
            AccNumlbl.Text = "Account Number: " + Login.AccNumber;
            

        }

        private void AccNumBl_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Logout
        private void customButton1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
