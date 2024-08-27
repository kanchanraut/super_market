using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Common;

namespace Supermarket__deskstop__application
{
    public partial class Categories : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["mystring"].ConnectionString;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Categories()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Bind_DataGridView();
            tb_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_des.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        private void Add_btn(object sender, EventArgs e)
        {
            try
            {
               
                if (tb_id.Text != "" && tb_name.Text != "" && tb_des.Text != "")
                {
                    con = new SqlConnection(cs);
                    cmd = new SqlCommand("Insert into tbl_categories values(@CatName,@CatDis)", con);
                    cmd.Parameters.AddWithValue("@CatName", tb_name.Text);
                    cmd.Parameters.AddWithValue("@CatDis", tb_des.Text);

                    con.Open();

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show(" Categories Data inserted successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Bind_DataGridView();
                        tb_id.Text = "";
                        tb_name.Text = "";
                        tb_des.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert data!", "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    }
                }
                else
                {

                    MessageBox.Show("Please enter all category details", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Bind_DataGridView()
        {
             con =new SqlConnection(cs);
             string cmd = "select*from tbl_Categories";
             SqlDataAdapter da = new SqlDataAdapter(cmd, con);
             DataTable dt=new DataTable();
             da.Fill(dt);
             dataGridView1.DataSource = dt;
           
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Bind_DataGridView();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //tb_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //tb_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //tb_des.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_id.Text == "")
                {
                    MessageBox.Show("Select category id to delete data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    con = new SqlConnection(cs);
                    string query = "Delete from tbl_categories WHERE CatId=@CatId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@CatId", tb_id.Text);
                   
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Bind_DataGridView();
                    tb_id.Text = "";
                    tb_name.Text = "";
                    tb_des.Text = "";

                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void update_click(object sender, EventArgs e)
        {
            try
            {

                if (tb_id.Text != "" && tb_name.Text != "" && tb_des.Text != "")
                {
                    con = new SqlConnection(cs);
                    string query = "Update tbl_categories SET  cateName=@catName , catDis=@catDis where CatId=@CatId";

                    SqlCommand cmd =new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@CatId", tb_id.Text);
                    cmd.Parameters.AddWithValue("@CatName", tb_name.Text);
                    cmd.Parameters.AddWithValue("@CatDis", tb_des.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Update Successfully", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Bind_DataGridView();
                    tb_id.Text = "";
                    tb_name.Text = "";
                    tb_des.Text = "";

                }
                else
                {
                    MessageBox.Show("please Enter the datails", "ERROE", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
            this.Hide();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            //Homefrom homefrom=new Homefrom();
            //homefrom.ShowDialog();
            //this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}



