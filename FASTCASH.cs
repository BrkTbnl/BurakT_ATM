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
    public partial class FASTCASH : Form
    {
        public FASTCASH()
        {
            InitializeComponent();
        }

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
                    BalanceLbl.Text = "Balance: PLN " + dt.Rows[0]["Balance"].ToString();
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

        private void Withdraw(int amount)
        {
            if (bal < amount)
            {
                MessageBox.Show("Insufficient Balance");
            }
            else
            {
                int newbalance = bal - amount;
                string query = "update AccountTbl set Balance = @NewBalance where AccNum = @AccNum";

                using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@NewBalance", newbalance);
                    cmd.Parameters.AddWithValue("@AccNum", Acc);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Success Withdraw!");

                        // Add transaction after successful withdrawal
                        addTransaction(Acc, "FastCash", amount);
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

        //10
        private void button1_Click(object sender, EventArgs e)
        {
            Withdraw(10);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        //20
        private void button3_Click(object sender, EventArgs e)
        {
            Withdraw(20);

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        //50
        private void button5_Click(object sender, EventArgs e)
        {
            Withdraw(50);

        }
        //100
        private void button2_Click_1(object sender, EventArgs e)
        {
            Withdraw(100);

        }

        //200
        private void button4_Click_1(object sender, EventArgs e)
        {
            Withdraw(200);

        }
        //500
        private void button6_Click_1(object sender, EventArgs e)
        {
            Withdraw(500);

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void FASTCASH_Load(object sender, EventArgs e)
        {
            getBalance();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
