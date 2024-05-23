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
    public partial class withdraw : Form
    {
        String Acc = Login.AccNumber;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\btaba\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        int bal;

        private void getBalance()
        {
            try
            {
                Con.Open();
                string query = "select Balance from AccountTbl where AccNum=@AccNum";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                sda.SelectCommand.Parameters.AddWithValue("@AccNum", Acc);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    balancelbl.Text = "Balance: PLN " + dt.Rows[0]["Balance"].ToString();
                    bal = Convert.ToInt32(dt.Rows[0]["Balance"].ToString());
                }
                else
                {
                    MessageBox.Show("Account not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching the balance: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        public withdraw()
        {
            InitializeComponent();
        }

        private void withdraw_Load(object sender, EventArgs e)
        {
            getBalance();
        }
        string trType = "Withdraw";

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

        // Withdraw button
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(withdrawTb.Text))
            {
                MessageBox.Show("Missing Information");
            }
            else if (!int.TryParse(withdrawTb.Text, out int withdrawAmount) || withdrawAmount <= 0)
            {
                MessageBox.Show("Please enter a valid Amount");
            }
            else if (withdrawAmount > bal)
            {
                MessageBox.Show("Balance cannot be negative");
            }
            else
            {
                int newbalance = bal - withdrawAmount;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance = @NewBalance where AccNum = @AccNum";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@NewBalance", newbalance);
                    cmd.Parameters.AddWithValue("@AccNum", Acc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("An Error Occurred:\n " + Ex.Message);
                }
                finally
                {
                    Con.Close();
                    addTransaction(Acc, trType, withdrawAmount);
                }

                HOME hOME = new HOME();
                hOME.Show();
                this.Hide();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void balancelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
