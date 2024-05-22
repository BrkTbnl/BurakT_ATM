using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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


        public static string AccNumber;

        //Login page Login button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where Accnum=@AccNum and PIN=@PIN", Con);
                sda.SelectCommand.Parameters.AddWithValue("@AccNum", AccNumTb.Text.Trim());

                // Check if PIN is numeric
                if (int.TryParse(PinTb.Text.Trim(), out int pin))
                {
                    sda.SelectCommand.Parameters.AddWithValue("@PIN", pin);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    // Check if there are any rows returned
                    if (dt.Rows.Count > 0 && dt.Rows[0][0].ToString() == "1")
                    {
                        AccNumber = AccNumTb.Text;
                        HOME home = new HOME();
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Account Number or PIN Code");
                    }
                }
                else
                {
                    MessageBox.Show("PIN must be a numeric value");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}