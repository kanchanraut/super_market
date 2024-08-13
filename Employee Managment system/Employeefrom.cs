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

namespace Employee_Managment_system
{
    public partial class Employeefrom : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["mystring"].ConnectionString;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Employeefrom()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_emp.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_fname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_Lname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_phn.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cb_gender.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cb_position.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Employeefrom_Load(object sender, EventArgs e)
        {

        }

        private void Add_click(object sender, EventArgs e)
        {
            try
            {
                if (tb_emp.Text != "" && tb_fname.Text != "" && tb_Lname.Text != "" && tb_phn.Text != "" && cb_gender.Text != "" && cb_position.Text != "")
                {
                    con = new SqlConnection(cs);
                    cmd = new SqlCommand("insert into tbl_employee values(@Fname,@Lname,@phone,@gender,@Position)", con);
                    cmd.Parameters.AddWithValue("@Fname", tb_fname.Text);
                    cmd.Parameters.AddWithValue("@Lname", tb_Lname.Text);
                    cmd.Parameters.AddWithValue("@Phone", tb_phn.Text);
                    cmd.Parameters.AddWithValue("@gender", cb_gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Position", cb_position.SelectedItem.ToString());

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Add Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    BindData_Gridview();
                    tb_fname.Text = "";
                    tb_Lname.Text = "";
                    tb_emp.Text = "";
                    tb_phn.Text = "";
                    cb_gender.Text = "";
                    cb_position.Text = "";
                    con.Close();
    
                }
                else
                {
                    MessageBox.Show("Please Enter All Details", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BindData_Gridview()
        {
            con = new SqlConnection(cs);
            string cmd = "select*from tbl_employee";
            SqlDataAdapter da= new SqlDataAdapter(cmd, con);
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void cb_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            BindData_Gridview();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            home home=new home();
            home.ShowDialog();
            this.Hide();
                
        }

        private void tb_emp_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_emp.Text != "" && tb_fname.Text != "" && tb_Lname.Text != "" && tb_phn.Text != "" && cb_gender.Text != "" && cb_position.Text != "")
                {
                    con = new SqlConnection(cs);
                    string query = "Update tbl_employee SET Fname=@Fname,Lname=@Lname, phone=@phone,Gender=@Gender," +
                        "position=@position WHERE EmpID=@EmpID";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@EmpID", tb_emp.Text);
                    cmd.Parameters.AddWithValue("@Fname", tb_fname.Text);
                    cmd.Parameters.AddWithValue("@Lname", tb_Lname.Text);
                    cmd.Parameters.AddWithValue("@phone", tb_phn.Text);
                    cmd.Parameters.AddWithValue("@Gender", cb_gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Position", cb_position.SelectedItem.ToString());

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    BindData_Gridview();
                    tb_emp.Text = "";
                    tb_fname.Text = "";
                    tb_Lname.Text = "";
                    tb_phn.Text = "";
                    cb_gender.Text = "";
                    cb_position.Text = "";

                }
                else
                {
                    MessageBox.Show("Please select the data", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            tb_emp.Text = "";
            tb_fname.Text = "";
            tb_Lname.Text = "";
            tb_phn.Text = "";
            cb_gender.Text = "";
            cb_position.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tb_emp.Text == "")
            {
                MessageBox.Show("please Select Id", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                con = new SqlConnection(cs);
                string query = "Delete from tbl_employee Where EmpID=@EmpID";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@EmpID", tb_emp.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BindData_Gridview();
                tb_emp.Text = "";
                tb_fname.Text = "";
                tb_Lname.Text = "";
                tb_phn.Text = "";
                cb_gender.Text = "";
                cb_position.Text = "";
            }
        }
    }
   
}

