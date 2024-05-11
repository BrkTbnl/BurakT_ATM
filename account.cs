using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BurakT_ATM
{
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\btaba\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();
                        string query = "SELECT * FROM AccountTbl WHERE AccountNumber = @AccountNumber AND Pin = @Pin";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@AccountNumber", AccNumTb.Text);
                            cmd.Parameters.AddWithValue("@Pin", pintb.Text);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // If the account and pin match, display a success message
                                    MessageBox.Show("Login Successful");
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Account Number or Pin");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Missing Information");
            }
        }

        private bool IsInputValid()
        {
            return !string.IsNullOrEmpty(AccNametb.Text) && !string.IsNullOrEmpty(AccNumTb.Text) && !string.IsNullOrEmpty(FanameTb.Text) && !string.IsNullOrEmpty(PhoneTb.Text) && !string.IsNullOrEmpty(Addresstb.Text) && !string.IsNullOrEmpty(occupationtb.Text) && !string.IsNullOrEmpty(pintb.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)

        {

            // Add your panel1_Paint logic here

        }


        private void label4_Click(object sender, EventArgs e)

        {

            // Add your label4_Click logic here

        }


        private void label9_Click(object sender, EventArgs e)

        {

            // Add your label9_Click logic here

        }
    }
}