using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
        string TrType = "Deposit";


        private void addTransaction(string accNum, string trType, int amount)
        {
            string query = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) " +
                           "VALUES (@AccNum, @Type, @Amount, @TDate)";

            using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@AccNum", accNum);
                cmd.Parameters.AddWithValue("@Type", trType);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@TDate", DateTime.Now.ToString("dd-MM-yy HH:mm:ss"));

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        // deposit function
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
                string query = "UPDATE AccountTbl SET Balance = @NewBalance WHERE AccNum = @AccNum";

                using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@NewBalance", newbalance);
                    cmd.Parameters.AddWithValue("@AccNum", Acc);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deposit Successful!");

                        // Add transaction after successful deposit
                        addTransaction(Acc, "Deposit", depositAmount);
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("An Error Occurred:\n " + Ex.Message);
                    }
                }

                HOME hOME = new HOME();
                hOME.Show();
                this.Hide();
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
