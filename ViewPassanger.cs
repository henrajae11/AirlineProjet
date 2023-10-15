using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AirlineProjet
{
    public partial class Vi : Form
    {
        public Vi()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rajae\OneDrive\Documents\AirlineDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM PassangerTb";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PassangerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
  
        private void Vi_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPassanger addpas = new AddPassanger();
            addpas.Show();
            this.Hide();
        }
    }
}
