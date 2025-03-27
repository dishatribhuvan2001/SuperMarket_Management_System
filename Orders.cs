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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Supermarket_Management_System
{
    public partial class Orders : Form
    {

        public Orders()
        {

            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Ordincbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Random rr = new Random();
                textBox1.Text = rr.Next(0, 1000).ToString();
                int orderid = Convert.ToInt32(textBox1.Text);
                int customerid = Convert.ToInt32(textBox2.Text);
                int productid = Convert.ToInt32(textBox3.Text);
                int quantity = Convert.ToInt32(textBox4.Text);
                int amount = Convert.ToInt32(textBox5.Text);


                string query = "Insert INTO Orders(OrderID,CustomerID,ProductID,Quantity,Amount) VALUES (@OrderID,@CustomerID,@ProductID,@Quantity,@Amount)";
                SqlConnection conn = new DatabaseConnection().GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", orderid);
                cmd.Parameters.AddWithValue("@CustomerID", customerid);
                cmd.Parameters.AddWithValue("@ProductID", productid);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Order Placed Successfully");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Prices()
        {
            try
            {
                int pid = Convert.ToInt32(textBox3.Text);
                string Connectionstring = "Data Source=localhost\\sqlexpress;Initial Catalog=Marketdb;Integrated Security=True;TrustServerCertificate=True";
                SqlConnection conn = new SqlConnection(Connectionstring);
                conn.Open();
                string query = $"SELECT Price FROM Products WHERE ProductID = @ProductID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", pid);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    decimal quantity= Convert.ToDecimal(textBox4.Text);
                    int price = Convert.ToInt32(result);
                    decimal amount = price * quantity;
                    textBox5.Text = amount.ToString();
                }
                else
                {
                    MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

       

        //Show data button code
        private void button1_Click(object sender, EventArgs e)
        {
            string Connectionstring = "Data Source=localhost\\sqlexpress;Initial Catalog=Marketdb;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(Connectionstring);
            string query = "SELECT * FROM Orders";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Orddelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int Orderid = Convert.ToInt32(textBox1.Text);
                string query = "DELETE FROM Order WHERE OrderID=@OrderID";
                SqlConnection conn = new DatabaseConnection().GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", Orderid);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Deleted Successfully");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cusresbtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "Data Source=localhost\\sqlexpress;Initial Catalog=Marketdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                SqlConnection conn = new SqlConnection(str);
                string query = "SELECT * FROM Products";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", "%" + textBox3.Text + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataView dv = new DataView(dt);
                // Convert ProductID to a string before filtering
                dv.RowFilter = $"CONVERT(ProductID, 'System.String') LIKE '%{textBox3.Text}%'";
                dataGridView1.DataSource = dv;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No records found matching the entered Product ID pattern.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prices();
        }
    }
}
