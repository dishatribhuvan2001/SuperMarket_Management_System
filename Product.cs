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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Proincbtn_Click(object sender, EventArgs e)
        {
            int productid = Convert.ToInt32(textBox1.Text);
            string productname = textBox2.Text;
            string category = textBox3.Text;
            decimal price = Convert.ToDecimal(textBox4.Text);

            string query = "Insert INTO Products(ProductID,ProductName,Category,Price) VALUES (@productid,@productname,@category,@price)";
            SqlConnection conn = new DatabaseConnection().GetSqlConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);   
            cmd.Parameters.AddWithValue("@ProductID", productid);
            cmd.Parameters.AddWithValue("@ProductName", productname);
            cmd.Parameters.AddWithValue("@Category", category);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.ExecuteNonQuery();
                
            
            MessageBox.Show("Record Inserted Successfully");
            ProductData();
        }

        private void ProductData()
        {
            string query = "SELECT * FROM Products";
            SqlConnection conn = new DatabaseConnection().GetSqlConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adpter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpter.Fill(dt);
            dataGridView1.DataSource = dt;
        }



        private void Proupdbtn_Click(object sender, EventArgs e)
        {
            int productid = Convert.ToInt32(textBox1.Text);
            string productname = textBox2.Text;
            string category = textBox3.Text;
            decimal price = Convert.ToDecimal(textBox4.Text);

            string query = "UPDATE Products SET ProductName=@productname,Category=@category,Price=@price WHERE ProductID=@ProductID";
            SqlConnection conn = new DatabaseConnection().GetSqlConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ProductID", productid);
            cmd.Parameters.AddWithValue("@ProductName", productname);
            cmd.Parameters.AddWithValue("@Category", category);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
            ProductData();
        }

        private void Prodelbtn_Click(object sender, EventArgs e)
        {
            int productid = Convert.ToInt32(textBox1.Text);

            string query = "DELETE FROM Products WHERE ProductID=@ProductID";
            SqlConnection conn = new DatabaseConnection().GetSqlConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ProductID", productid);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Deleted Successfully");
            ProductData();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            ProductData();
        }

        private void Proresbtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
