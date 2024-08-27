using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket__deskstop__application
{
    public partial class Seller : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["mystring"].ConnectionString;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Seller()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ProductForm productForm=new ProductForm();
            productForm.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Show();
            this.Hide();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Selling selling = new Selling();
            selling.Show();
            selling.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_id.Text != "" && tb_sellernm.Text != "" && tb_age.Text != "" && tb_phn.Text != "" && tb_pass.Text != "")
                {
                    con = new SqlConnection(cs);
                    cmd = new SqlCommand("insert into tbl_seller values(@sellName,@sellAge,@sellphone,@sellPassword)", con);
                    cmd.Parameters.AddWithValue("@sellName", tb_sellernm.Text);
                    cmd.Parameters.AddWithValue("@sellAge", tb_age.Text);
                    cmd.Parameters.AddWithValue("@sellphone", tb_phn.Text);
                    cmd.Parameters.AddWithValue("@sellPassword", tb_pass.Text);

                   con.Open();
                   int i = cmd.ExecuteNonQuery(); 
                    if (i > 0)
                    {
                        MessageBox.Show("Data Added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_id.Text = "";
                        tb_sellernm.Text = "";
                        tb_pass.Text = "";
                        tb_age.Text = "";
                        tb_phn.Text = "";

                        DataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert data!", "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Please Enter All details", "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DataGridView()
        {
            con=new SqlConnection(cs);
            string query = "select*from tbl_seller";
            SqlDataAdapter dataAdapter=new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            tb_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_sellernm.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_age.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_phn.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tb_pass.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_id.Text == "")
                {
                    MessageBox.Show("Please enter the Id", "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    con = new SqlConnection(cs);
                    string query = "Delete from  tbl_seller Where SellId=@SellId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@SellId", tb_id.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DataGridView();
                    tb_id.Text = "";
                    tb_sellernm.Text ="";
                    tb_pass.Text ="";
                    tb_age.Text = "";
                    tb_phn.Text = "";

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_id.Text != "" && tb_sellernm.Text != "" && tb_age.Text != "" && tb_phn.Text != "" && tb_pass.Text != "")
                {
                    con = new SqlConnection(cs);
                    string query = "Update tbl_seller SET sellName=@sellName,sellAge=@sellAge,sellPhone=@sellPhone,sellPass=@sellPass  " +
                        "Where SellID=@SellID";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@sellID", tb_id.Text);
                    cmd.Parameters.AddWithValue("@sellName", tb_sellernm.Text);
                    cmd.Parameters.AddWithValue("@sellAge", tb_age.Text);
                    cmd.Parameters.AddWithValue("@sellPhone", tb_phn.Text);
                    cmd.Parameters.AddWithValue("@sellPass", tb_pass.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data Update successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DataGridView();
                    tb_id.Text = "";
                    tb_sellernm.Text = "";
                    tb_pass.Text = "";
                    tb_age.Text = "";
                    tb_phn.Text = "";
                }
                else
                {
                    MessageBox.Show("Please Enter details", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}































