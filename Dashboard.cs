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

namespace Supermarket_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Display1();
            Display2();
            Display3();
        }
        private void Display1()
        {
            string Connectionstring = "Data Source=localhost\\sqlexpress;Initial Catalog=Marketdb;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(Connectionstring);
            try
            {
                conn.Open();
                string query = "SELECT Count(*) FROM Products";

                SqlCommand cmd = new SqlCommand(query, conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                lblCount1.Text = "Total Products: " + count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Display2()
        {
            string Connectionstring = "Data Source=localhost\\sqlexpress;Initial Catalog=Marketdb;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(Connectionstring);
            try
            {
                conn.Open();
                string query = "SELECT Count(*) FROM Orders";

                SqlCommand cmd = new SqlCommand(query, conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                lblCount2.Text = "Total Orders: " + count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Display3()
        {
            string Connectionstring = "Data Source=localhost\\sqlexpress;Initial Catalog=Marketdb;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(Connectionstring);
            try
            {
                conn.Open();
                string query = "SELECT Count(*) FROM Customers";

                SqlCommand cmd = new SqlCommand(query, conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                lblCount3.Text = "Total Customers: " + count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}





















