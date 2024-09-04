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
    public partial class InventoryMaster : Form
    {
        public InventoryMaster()
        {
            InitializeComponent();
            DisplayInventoryMaster();
        }
        readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=LAPTOP-NAC6BQ5B;Initial Catalog=StockMangament;Integrated Security=True");
        private void DisplayInventoryMaster()
        {
            try
            {
                Con.Open();
                string Query = "select * from InventoryMaster";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView3.DataSource = ds.Tables[0];
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

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    String query = "insert into InventoryMaster Values('"+ textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Entered Sucessfully");
                    DisplayInventoryMaster();
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
                if (textBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = " update InventoryMaster Set IN_ID=@IN_ID, IN_NAME =@IN_NAME, IN_DESC = @IN_DESC where IN_ID=@IN_ID";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@IN_ID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@IN_NAME", textBox2.Text);
                    cmd.Parameters.AddWithValue("@IN_DESC", textBox3.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record updated sucessfully");
                    DisplayInventoryMaster();
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
                    MessageBox.Show("Enter the INVENTORY MASTER ID");
                }
                else
                {
                    Con.Open();
                    string query = "delete from InventoryMaster where IN_ID='" + textBox1.Text + "' ;";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record deleted sucessfully");
                    DisplayInventoryMaster();
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
                textBox3.Text = " ";
            
        }
        }

        private void HomeBtn_Click_1(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void dataGridView3_CellContentClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
                textBox3.Text = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();

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

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InventoryMaster_Load(object sender, EventArgs e)
        {
            DisplayInventoryMaster();
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

    }
}