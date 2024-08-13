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


    public partial class Registerform : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["mystring"].ConnectionString;
        SqlConnection conn = new SqlConnection();
        SqlCommand Command = new SqlCommand();
        public Registerform()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_fullname.Text != "" && tb_phon.Text != "" && tb_username.Text!="" &&
                    tb_email.Text != "" && tb_pass.Text != "" && tb_confpass.Text != "")
                {
                    conn = new SqlConnection(cs);
                    Command = new SqlCommand("insert into tbl_register values(@FullName,@Username,@PhoneNo," +
                        "@Email,@Password,@ConfirmPass)", conn);

                    Command.Parameters.AddWithValue("@FullName", tb_fullname.Text);
                    Command.Parameters.AddWithValue("@Username",tb_username.Text);
                    Command.Parameters.AddWithValue("@PhoneNo", tb_phon.Text);
                    Command.Parameters.AddWithValue("@Email", tb_email.Text);
                    Command.Parameters.AddWithValue("@Password", tb_pass.Text);
                    Command.Parameters.AddWithValue("@ConfirmPass", tb_confpass.Text);

                    conn.Open();
                    int i = Command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Register Successful", "Register", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        loginfrom loginfrom = new loginfrom();
                        loginfrom.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("failed to Register", "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter All Details For Register", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    tb_fullname.Text = "";
                    tb_username.Text = "";
                    tb_phon.Text = "";
                    tb_email.Text = "";
                    tb_pass.Text = "";
                    tb_confpass.Text = "";

                }
            }  catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
