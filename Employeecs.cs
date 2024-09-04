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

namespace Stock_Management_System
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            DisplayEmployee();
        }
        readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=LAPTOP-NAC6BQ5B;Initial Catalog=StockMangament;Integrated Security=True");
        private void DisplayEmployee()
        {
            try
            {
                Con.Open();
                string Query = "select * from Employee";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                Con.Close();
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            DisplayEmployee();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void HomeBtn_Click_1(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();

        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " " || textBox5.Text == " " || textBox6.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    String query = "insert into Employee Values('" + textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Entered Sucessfully");
                    DisplayEmployee();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                Con.Close();
            }
        }

        private void ResetBtn_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " ")
                {
                    MessageBox.Show("Enter the Employee ID");
                }
                else
                {
                    Con.Open();
                    string query = "delete from Employee where EMP_ID='" + textBox1.Text + "' ;";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record deleted sucessfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " " || textBox5.Text == " " || textBox6.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = " update Employee Set EMP_ID=@EMP_ID, EMP_NAME =@EMP_NAME,EMP_COMP_ID=@EMP_COMP_ID, EMP_MAILID =@EMP_MAILID,  EMP_MOBILENO=@EMP_MOBILENO, EMP_PASSWORD =@EMP_PASSWORD where EMP_ID=@EMP_ID";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@EMP_ID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@EMP_NAME", textBox2.Text);
                    cmd.Parameters.AddWithValue("@EMP_COMP_ID", textBox3.Text);
                    cmd.Parameters.AddWithValue("@EMP_MAILID", textBox4.Text);
                    cmd.Parameters.AddWithValue("@EMP_MOBILENO", textBox5.Text);
                    cmd.Parameters.AddWithValue("@EMP_PASSWORD", textBox6.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record updated sucessfully");
                    DisplayEmployee();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();

            }
        }

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}