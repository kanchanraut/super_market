using Supermarket_deskstop_application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Supermarket__deskstop__application
{
    public partial class ProductForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["mystring"].ConnectionString;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd=new SqlCommand();
        public ProductForm()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindData();
            tb_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_price.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_qnty.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cb_cat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Show();
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller();
            seller.ShowDialog();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Selling selling = new Selling();
            selling.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if(tb_id.Text=="" && tb_name.Text==""&& tb_qnty.Text==""&& tb_price.Text == "")
                {
                    MessageBox.Show("No Field Should Be Blank", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    con = new SqlConnection(cs);
                    cmd = new SqlCommand("Insert into tbl_product values(@prodName,@prodqty,@prodprie,@prodcat)",con);
                    cmd.Parameters.AddWithValue("@prodName", tb_name.Text);
                    cmd.Parameters.AddWithValue("@prodqty", tb_qnty.Text);
                    cmd.Parameters.AddWithValue("@prodprie", tb_price.Text);
                    cmd.Parameters.AddWithValue("@prodcat", cb_cat.SelectedItem);
                    con.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Add Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    BindData();
                    tb_id.Text = "";
                    tb_name.Text = "";
                    tb_price.Text = "";
                    tb_qnty.Text = "";

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BindData()
        {
            con =new SqlConnection(cs);
            string query = "select*from tbl_product";
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            DataTable dt= new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void BindDatas()
        {
            con = new SqlConnection(cs);
            string query = "select*from tbl_product";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs);
                cmd = new SqlCommand("Delete from tbl_product where @ProdID=ProdID", con);
                cmd.Parameters.AddWithValue("@ProdID", tb_id.Text);
                con.Open();
                MessageBox.Show("DATA delete Successfully", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BindData();
                tb_id.Text = "";
                tb_name.Text = "";
                tb_price.Text = "";
                tb_qnty.Text = "";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Homefrom homefrom=new Homefrom();
            homefrom.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_id.Text != "" && tb_name.Text != "" && tb_qnty.Text != "" && tb_price.Text != "" && cb_cat.Text!="")

                {
                    con = new SqlConnection(cs);
                    string query = "Update tbl_product SET  prodName=@prodName , prodqty=@prodqty,prodprie=@prodprie,prodcat=@prodcat where prodId=@prodId";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@prodId", tb_id.Text);
                    cmd.Parameters.AddWithValue("@prodName", tb_name.Text);
                    cmd.Parameters.AddWithValue("@prodqty", tb_qnty.Text);
                    cmd.Parameters.AddWithValue("@prodprie", tb_price.Text);
                    cmd.Parameters.AddWithValue("@prodcat", cb_cat.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Update Successfully", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    BindData();
                    tb_id.Text = "";
                    tb_name.Text = "";
                    tb_price.Text = "";
                    tb_qnty.Text = "";
                    cb_cat.Text = "";

                }
                else
                {
                    MessageBox.Show("please Enter the datails", "ERROE", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}




