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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\btaba\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");


        //Pin character check
        private bool ContainsDuplicateCharacters(string input)
        {
            HashSet<char> charSet = new HashSet<char>();
            foreach (char c in input)
            {
                if (charSet.Contains(c))
                {
                    return true;
                }
                charSet.Add(c);
            }
            return false;
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

        //Change pin
        private void customButton1_Click(object sender, EventArgs e)
        {

            String Acc = Login.AccNumber;

            if (string.IsNullOrEmpty(Pin1.Text) || string.IsNullOrEmpty(Pin2.Text))
            {
                MessageBox.Show("Enter And Confirm The New Pin");
            }
            else if (Pin2.Text != Pin1.Text)
            {
                MessageBox.Show("Pin codes must match");
            }
            else if (ContainsDuplicateCharacters(Pin1.Text))
            {
                MessageBox.Show("PIN should not contain duplicate characters.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Pin = @NewPin where AccNum = @AccNum";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@NewPin", Pin1.Text);
                    cmd.Parameters.AddWithValue("@AccNum", Acc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN Successfully Changed!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("An Error Occurred:\n " + Ex.Message);
                }
                finally
                {
                    Con.Close();
                }

                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        //Turn Back
        private void customButton2_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }
    }
}
