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
    public partial class Register_Page : Form
    {
        public Register_Page()
        {
            InitializeComponent();
        }

        private void Reglogbtn_Click(object sender, EventArgs e)
        {
            Admin_Login al = new Admin_Login();
            al.Show();
        }

        private void Regregbtn_Click(object sender, EventArgs e)
        {
            //    try
            //    {
            //        if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(comboBox2.Text) || string.IsNullOrWhiteSpace(comboBox1.Text)) 
            //        {

            //                MessageBox.Show("Please enter all fields", "validating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                return;

            //        }


            //        string Username = textBox1.Text;
            //        string Pass = textBox2.Text;
            //        string Mobileno = textBox3.Text;
            //        String Role = comboBox2.Text;
            //        String Gender = comboBox1.Text;


            //        string query = "Insert INTO Users(Username,Pass,Mobileno,Role,Gender) VALUES (@Username,@Pass,@Mobileno,@Role,@Gender)";
            //        SqlConnection conn = new DatabaseConnection().GetSqlConnection();
            //        conn.Open();
            //        SqlCommand cmd = new SqlCommand(query, conn);
            //        cmd.Parameters.AddWithValue("@Username", Username);
            //        cmd.Parameters.AddWithValue("@Pass", Pass);
            //        cmd.Parameters.AddWithValue("@Mobileno", Mobileno);
            //        cmd.Parameters.AddWithValue("@Gender", Gender);
            //        cmd.ExecuteNonQuery();



            //        MessageBox.Show("Successfully Registered");
            //        Admin_Login al = new Admin_Login();
            //        al.Show();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.StackTrace);
            //    }

            //}


            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(comboBox2.Text) ||
                    string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show("Please enter all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string Username = textBox1.Text;
                string Pass = textBox2.Text;
                string Mobileno = textBox3.Text;
                string Role = comboBox2.Text;
                string Gender = comboBox1.Text;

                // Hashing password
                //   string hashedPass = Convert.ToBase64String(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(Pass)));

                string query = "INSERT INTO Users(Username, Pass, Mobileno, Role, Gender) VALUES (@Username, @Pass, @Mobileno, @Role, @Gender)";

                using (SqlConnection conn = new DatabaseConnection().GetSqlConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@Pass", Pass);
                        cmd.Parameters.AddWithValue("@Mobileno", Mobileno);
                        cmd.Parameters.AddWithValue("@Role", Role);
                        cmd.Parameters.AddWithValue("@Gender", Gender);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Successfully Registered");
                this.Hide();
                Admin_Login al = new Admin_Login();
                al.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}