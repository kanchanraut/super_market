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
    public partial class Details : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["mystring"].ConnectionString;
        SqlConnection connection = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Details()
        {
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void Fetchemp()
        {
            try
            {
                //connection.Open();
                connection = new SqlConnection(cs);
                string query = "Select*From tbl_employee where EmpID=' "+tb_id.Text+" '";
                SqlCommand cmd = new SqlCommand(query, connection);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {                
                    lbl_id.Text = dr["EmpID"].ToString();
                    lbl_nm.Text = dr["Fname"].ToString();
                    lbl_ln.Text = dr["Lname"].ToString();
                    lbl_ph.Text = dr["phone"].ToString();
                    lbl_gender.Text = dr["Gender"].ToString().ToLower();
                    lbl_position.Text = dr["Position"].ToString();
                    lbl_id.Visible = true;
                    lbl_nm.Visible = true;
                    lbl_ln.Visible = true;
                    lbl_ph.Visible = true;
                    lbl_gender.Visible = true;
                    lbl_position.Visible = true;

                }
                connection.Close();

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Fetchemp();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.ShowDialog();
            this.Hide();
        }
        private void tb_id_TextChanged(object sender, EventArgs e)
        {
            Fetchemp();
            lbl_id.Text = "";
            lbl_nm.Text = "";
            lbl_ln.Text = "";
            lbl_ph.Text = "";
            lbl_gender.Text = "";
            lbl_position.Text = "";
        }
    }
}
