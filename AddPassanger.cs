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

namespace AirlineProjet
{
    public partial class AddPassanger : Form
    {
        public AddPassanger()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rajae\OneDrive\Documents\AirlineDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(PassId.Text== "" || PassAd.Text== "" || PassName.Text== "" || PassportTb.Text== "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else 
            {
                try
                {
                    Con.Open();
                    string query = "insert into PassangerTb values("+ PassId.Text +",'"+ PassName.Text +"','"+ PassportTb.Text +"','"+ PassAd.Text +"','"+ NationalityCb.SelectedItem.ToString() +"','"+ GenderCb.SelectedItem.ToString() +"','"+ PhoneTb.Text +"')";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passanger Recorded Successfully");
                    Con.Close();
                }catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
           
        
            
            }
        }

        private void AddPassanger_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vi viewpass = new Vi();
            viewpass.Show();
            this.Hide();    

        }
    }
}
