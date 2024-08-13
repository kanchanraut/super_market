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

namespace Employee_Managment_system
{
    public partial class loginfrom : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["mystring"].ConnectionString;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public loginfrom()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void loginfrom_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registerform registerform = new Registerform();
            registerform.ShowDialog();
        }
        private void Login_Click(object sender, EventArgs e)
        {
            string Username = tb_user.Text;
            string Password = tb_pass.Text;
            try {
                if (tb_user != null && tb_pass != null)
                {
                    con = new SqlConnection(cs);
                    cmd = new SqlCommand($"Select*from tbl_register where username='{Username}' and password='{Password}'", con);
                    con.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (!dr.HasRows)
                    {
                        MessageBox.Show("Login Failed", "Filed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else if (dr.HasRows)
                    {
                        MessageBox.Show("Login Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        home home=new home();
                        this.Hide();
                        home.ShowDialog();
                        this.Close();
                        con.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Username And Password", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tb_pass.Clear();
            tb_user.Clear();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                tb_pass.UseSystemPasswordChar = false;
            }
            else
            {
                tb_pass.UseSystemPasswordChar= true;
            }
        }
    }
    }


