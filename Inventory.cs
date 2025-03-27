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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Invshowbtn_Click(object sender, EventArgs e)
        {
            string Connectionstring = "Data Source=localhost\\sqlexpress;Initial Catalog=Marketdb;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(Connectionstring);
            string query = "SELECT * FROM Inventory"; // Use square brackets for SQL reserved keywords
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt; // Bind data to GridView 
        }

        private void Invinsbtn_Click(object sender, EventArgs e)
        {

            try
            {
                int iid = Convert.ToInt32(textBox1.Text);
                int productid = Convert.ToInt32(textBox2.Text);
                int stockadded = Convert.ToInt32(textBox3.Text);
                int stockremoved = Convert.ToInt32(textBox4.Text);


                string query = "Insert INTO Inventory(IID,ProductID,StockAdded,StockRemoved) VALUES (@IID,@ProductID,@StockAdded,@StockRemoved)";
                SqlConnection conn = new DatabaseConnection().GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn); 
                    cmd.Parameters.AddWithValue("@IID", iid);
                    cmd.Parameters.AddWithValue("@ProductID", productid);
                    cmd.Parameters.AddWithValue("@StockAdded", stockadded);
                    cmd.Parameters.AddWithValue("@StockRemoved", stockremoved);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Inserted Successfully");
                    InventoryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InventoryData()
        {

        }

        private void Invupdbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int iid = Convert.ToInt32(textBox1.Text);
                int productid = Convert.ToInt32(textBox2.Text);
                decimal stockadded = Convert.ToDecimal(textBox3.Text);
                decimal stockremoved = Convert.ToDecimal(textBox4.Text);


                string query = "UPDATE Inventory SET  ProductID=@productid, StockAdded=@stockadded, StockRemoved=@StockRemoved WHERE IID=@iid";
                SqlConnection conn = new DatabaseConnection().GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@IID", iid);
                cmd.Parameters.AddWithValue("@ProductID", productid);
                cmd.Parameters.AddWithValue("@StockAdded", stockadded);
                cmd.Parameters.AddWithValue("@StockRemoved", stockremoved);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Record Updated Successfully");
                InventoryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Invdelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int IID = Convert.ToInt32(textBox1.Text);
                string query = "DELETE FROM Inventory WHERE IID=@iid";
                SqlConnection conn = new DatabaseConnection().GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IID", IID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Deleted Successfully");
                InventoryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Invresbtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}

