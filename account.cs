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

        private void button1_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccNametb.Text == "" || AccNumTb.Text == "" || FanameTb.Text == "" || PhoneTb.Text == "" || Addresstb.Text == "" || occupationtb.Text == "" || pintb.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "insert into AccountTbl values('" + AccNumTb.Text + "','" + AccNametb.Text + "','" + FanameTb.Text + "','" + dobdate.Value.Date + "','" + PhoneTb.Text + "','" + Addresstb.Text + "','" + educationcb.SelectedItem.ToString() + "','" + occupationtb.Text + "'," + pintb.Text + "," + bal + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Succesfully");
                    Con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }







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

        private void label13_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}