using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BurakT_ATM
{
    public partial class Balance : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\btaba\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" + AccNumberlbl.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balancelbl.Text = "PLN " + dt.Rows[0][0].ToString();
            Con.Close();
        }

        public Balance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //For balance page account number
        private void Balance_Load(object sender, EventArgs e)
        {
            AccNumberlbl.Text = HOME.AccNumber;
            getBalance();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Balance turn back
        private void customButton1_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
        }
    }
}
