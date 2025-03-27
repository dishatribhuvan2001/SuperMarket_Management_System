using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void Loginclrbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn =  new DatabaseConnection().GetSqlConnection();
                conn.Open();
                string selectData = "SELECT * FROM Users WHERE Username = @Username", Pass = "@Pass";
                SqlCommand cmd = new SqlCommand(selectData, conn);
                cmd.Parameters.AddWithValue("@Username", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@Pass", textBox1.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Login Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Market m = new Market();
                            m.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username/Password ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            

        private void Logregbtn_Click(object sender, EventArgs e)
        {
            Register_Page rp = new Register_Page();
            rp.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked == true)
            //    textBox2.Text = true;
            //else
            //    textBox2.Text = false;
        }

        private void Admin_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
