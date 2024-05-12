using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurakT_ATM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            account acc = new account();
            acc.Show();
            this.Hide();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\btaba\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where Accnum=@AccNum and PIN=@PIN", Con);
            sda.SelectCommand.Parameters.AddWithValue("@AccNum", AccNumTb.Text.Trim());

            // Convert the PIN input to an integer
            int pin = 0;

            if (int.TryParse(PinTb.Text.Trim(), out pin))
            {
                sda.SelectCommand.Parameters.AddWithValue("@PIN", pin);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Account Number or PIN Code");
                }
                Con.Close();
            }
        }
    }
}