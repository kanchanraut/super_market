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
    public partial class Salary : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["mystring"].ConnectionString;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

       
        public Salary()
        {
            InitializeComponent();
        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fetchemp();
        }
        private void Fetchemp()
        {
            try
            {
                if (tb_emp.Text == "")
                {
                    MessageBox.Show("Enter Employee ID");
                }
                else
                {
                    //con.Open();
                    con = new SqlConnection(cs);
                    string query = "Select*From tbl_employee where EmpID=EmpID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);


                    foreach (DataRow dr in dt.Rows)
                    {
                        tb_fname.Text = dr["Fname"].ToString();
                        tb_Lname.Text = dr["Lname"].ToString();
                        cb_position.Text = dr["position"].ToString();
                    }
                    con.Close();
                }

                }catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void tb_fname_TextChanged(object sender, EventArgs e)
        {

        }


        int Dailybase;
        int total;
        private void view(object sender, EventArgs e)
        {

            if (tb_fname.Text =="" && tb_Lname.Text == "")
            {
                MessageBox.Show("Select An Employee");
            }
            else if(tb_wd.Text==" " ||  Convert.ToInt32(tb_wd.Text)> 28)
            {
                MessageBox.Show("Enter valid numbers of days");                                                  
            }
            else
            {
                if (cb_position.Text == "mnager")
                {
                    Dailybase = 1200;
                }
                  else if(cb_position.Text == "Developer")
                {
                    Dailybase = 1200;

                }
                else if (cb_position.Text == "Tester")
                {
                    Dailybase = 1000;

                }
                else if (cb_position.Text == "Accountant")
                {
                    Dailybase = 1000;

                }
                else if (cb_position.Text == "Officer")
                {
                    Dailybase = 1400;

                }
                else 
                {
                    Dailybase = 800;

                }
                total=Dailybase*Convert.ToInt32(tb_wd.Text);
                ss.Text = "EmpId:" + tb_emp.Text + "\n" + "Fname:" + tb_fname.Text + "\n" + "Lname:" + tb_Lname.Text + "\n" +
                    "Position:" + cb_position.Text + "\n" + "Daily Salary:" + Dailybase + "\n" + "Total Amount:" + total;               
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.ShowDialog();
            this.Hide();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
