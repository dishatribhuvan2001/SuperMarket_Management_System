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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Proincbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int customerid = Convert.ToInt32(textBox1.Text);
                string customername = textBox2.Text;
                string phone = textBox3.Text;
                string address = textBox4.Text;

                string query = "Insert INTO Customers(CustomerID,CustomerName,Phone,Address) VALUES (@CustomerID,@CustomerName,@Phone,@Address)";
                SqlConnection conn = new DatabaseConnection().GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerid);
                cmd.Parameters.AddWithValue("@CustomerName", customername);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully");
                CustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void CustomerData()
        {
            string query = "SELECT * FROM Customers";
            SqlConnection conn = new DatabaseConnection().GetSqlConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adpter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Cusupdbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int customerid = Convert.ToInt32(textBox1.Text);
                string customername = textBox2.Text;
                string phone = textBox3.Text;
                string address = textBox4.Text;

                string query = "UPDATE Customers SET CustomerName=@customername,Phone=@phone,Address=@address WHERE CustomerID=@CustomerID";
                SqlConnection conn = new DatabaseConnection().GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerid);
                cmd.Parameters.AddWithValue("@CustomerName", customername);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully");
                CustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Cusdelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int Customerid = Convert.ToInt32(textBox1.Text);
                string query = "DELETE FROM Customers WHERE CustomerID=@CustomerID";
                SqlConnection conn = new DatabaseConnection().GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", Customerid);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully");
                CustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Cusresbtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            CustomerData();
        }

        
        private void Cusshwbtn_Click(object sender, EventArgs e)
        {
            string Connectionstring = "Data Source=localhost\\sqlexpress;Initial Catalog=Marketdb;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(Connectionstring);
            string query = "SELECT * FROM Customers";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}