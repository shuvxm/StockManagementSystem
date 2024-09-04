using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            obj.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void VcBtn_Click_1(object sender, EventArgs e)
        {
            InventoryDetails obj = new InventoryDetails();
            obj.Show();
            this.Hide();
        }

        private void VctypeBtn_Click_1(object sender, EventArgs e)
        {
            InventoryMaster obj = new InventoryMaster();
            obj.Show();
            this.Hide();
        }

       
    }
}

