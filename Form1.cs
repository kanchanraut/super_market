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
using Supermarket_deskstop_application;

namespace Supermarket__deskstop__application
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["mystring"].ConnectionString;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd= new SqlCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Login(object sender, EventArgs e)
        {
            string Username=tb_name.Text;
            string Password=tb_pass.Text;

            if(tb_name.Text=="" && tb_pass.Text == "")
            {
                MessageBox.Show("Please Enter the username and Password","Error",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if(tb_name.Text!="" && tb_pass.Text != "")
            {
                con = new SqlConnection(cs);
                cmd=new SqlCommand($"select*from tbl_Login where username='{Username}' and password='{Password}'",con);
                con.Open();

                SqlDataReader dr=cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("Login Failed!","Failed",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
                else if(dr.HasRows)
                {
                    MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Homefrom homefrom=new Homefrom();
                    homefrom.ShowDialog();
                    this.Hide();
                }
                con.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
