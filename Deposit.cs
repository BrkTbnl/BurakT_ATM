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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\btaba\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        String Acc = Login.AccNumber;

        int oldbalance, newbalance;

        private void button1_Click(object sender, EventArgs e)
        {
            int depositAmount;
            if (string.IsNullOrEmpty(DepoAmtTb.Text) || !int.TryParse(DepoAmtTb.Text, out depositAmount) || depositAmount <= 0)
            {
                MessageBox.Show("Enter a valid amount to deposit (positive number).");
            }
            else
            {
                newbalance = oldbalance + depositAmount;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance = @NewBalance where AccNum = @AccNum";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@NewBalance", newbalance);
                    cmd.Parameters.AddWithValue("@AccNum", Acc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deposit Successful!");
                    Con.Close();
                    HOME hOME = new HOME();
                    hOME.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void getBalance()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" + Acc + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    oldbalance = Convert.ToInt32(dt.Rows[0]["Balance"]);
                }
                else
                {
                    MessageBox.Show("Account not found!");
                }
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            getBalance();
        }
    }

}
