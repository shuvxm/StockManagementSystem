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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked == false)
                txtPassword.UseSystemPasswordChar = true;
            else
                txtPassword.UseSystemPasswordChar = false;

        }

        private void labelclear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPassword.Clear();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       /* private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }*/

      /*  private void LoginBtn_Click(object sender, EventArgs e)
        {
        }*/

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (txtName.Text == "Admin" && txtPassword.Text == "Password")
            {
                Home obj = new Stock_Management_System.Home();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("please Enter the correct username and password  ");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelclear_Click_1(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPassword.Clear();
        }
    }
}




       /* private void ClearBtn_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
            Password.Text = "";
        }*/
/*
       

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "" && Password.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (UserName.Text == "Admin" && Password.Text == "Password")
            {
                Home obj = new VaccineManagement.Home();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("please Enter the correct username and password  ");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
*/
