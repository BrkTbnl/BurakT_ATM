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
    public partial class ministatement : Form
    {

        public ministatement()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\btaba\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        String Acc = Login.AccNumber;
        private void populate()
        {
            Con.Open();
            string query = "select * from TransactionTbl where AccNum ='" + Acc + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MiniStatementDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void ministatement_Load(object sender, EventArgs e)
        {
            populate();
            //Set the DataGridView to read-only
            MiniStatementDGV.ReadOnly = true;
            // Auto resize the columns to fill the width of the form
            MiniStatementDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void MiniStatementDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

       

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //back button
        private void customButton1_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }
    }
}
