using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    public partial class Market : Form
    {
        public Market()
        {
            InitializeComponent();
        }

        private void Marprobtn_Click(object sender, EventArgs e)
        {
            Product pt = new Product();
            pt.Show();
        }

        private void Marcusbtn_Click(object sender, EventArgs e)
        {
            Customer cu = new Customer();
            cu.Show();
        }

        private void Marordbtn_Click(object sender, EventArgs e)
        {
            Orders or = new Orders();
            or.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
        }

        private void Mardasbtn_Click(object sender, EventArgs e)
        {
            Dashboard da = new Dashboard();
            da.Show();
        }
    }
}
