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

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\btaba\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");





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


        //Account exit
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AccNumTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void account_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //Account submit button
        private void customButton1_Click(object sender, EventArgs e)
        {
            
            if (AccNametb.Text == "" || AccNumTb.Text == "" || FanameTb.Text == "" || PhoneTb.Text == "" || Addresstb.Text == "" || occupationtb.Text == "" || pintb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (!int.TryParse(AccNumTb.Text, out _) || !long.TryParse(PhoneTb.Text, out _) || !int.TryParse(pintb.Text, out _))
            {
                MessageBox.Show("Invalid numeric input");
                return;
            }
            else
            {
                string query = "INSERT INTO AccountTbl (AccNum, Name, FaName, Dob, Phone, Address, Education, Occupation, Pin, Balance) " +
               "VALUES (@AccNum, @AccName, @FName, @DOB, @Phone, @Address, @Education, @Occupation, @PIN, @Balance)";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", AccNumTb.Text);
                cmd.Parameters.AddWithValue("@AccName", AccNametb.Text);
                cmd.Parameters.AddWithValue("@FName", FanameTb.Text);
                cmd.Parameters.AddWithValue("@DOB", dobdate.Value.Date);
                cmd.Parameters.AddWithValue("@Phone", PhoneTb.Text);
                cmd.Parameters.AddWithValue("@Address", Addresstb.Text);
                cmd.Parameters.AddWithValue("@Education", educationcb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Occupation", occupationtb.Text);
                cmd.Parameters.AddWithValue("@PIN", pintb.Text);
                cmd.Parameters.AddWithValue("@Balance", 0);

                try
                {
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
            }
        }

        //Account turnback to login
        private void customButton2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}