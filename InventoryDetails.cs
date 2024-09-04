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

namespace Stock_Management_System
{
    public partial class InventoryDetails : Form
    {
        public InventoryDetails()
        {
            InitializeComponent();
            DisplayInventoryDetails();
        }
        readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=LAPTOP-NAC6BQ5B;Initial Catalog=StockMangament;Integrated Security=True");
        private void DisplayInventoryDetails()
        {
            try
            {
                Con.Open();
                string Query = "select * from InventoryDetails";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " || textBox4.Text == " " || textBox5.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    String query = "insert into InventoryDetails Values('"+ textBox1.Text+"','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Entered Sucessfully");
                    DisplayInventoryDetails();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VaccinatedDetails_Load(object sender, EventArgs e)
        {
            DisplayInventoryDetails();
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "  " || textBox2.Text == "  " || textBox4.Text == "  " || textBox5.Text == "  ")

                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = " update InventoryDetails Set  INDET_ID=@INDET_ID, INDET_IN_ID =@INDET_IN_ID, INDET_AMOUNT =@INDET_AMOUNT, INDET_REMARKS =@INDET_REMARKS where INDET_ID=@INDET_ID";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@INDET_ID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@INDET_IN_ID", textBox2.Text);
                    cmd.Parameters.AddWithValue("@INDET_AMOUNT", textBox4.Text);
                    cmd.Parameters.AddWithValue("@INDET_REMARKS", textBox5.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record updated sucessfully");
                    DisplayInventoryDetails();
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

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text == " ")
                {
                    MessageBox.Show("Enter the inventory details ID");
                }
                else
                {
                    Con.Open();
                    string query = "delete from InventoryDetails where INDET_ID='" + textBox1.Text + "' ;";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record deleted sucessfully");
                    DisplayInventoryDetails();
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
            {
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
               
            }
        }

        private void HomeBtn_Click_1(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();

        }

        private void dataGridView2_CellContentClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                textBox4.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                textBox5.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
               

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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

       

       
    }
}