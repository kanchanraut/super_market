using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Managment_system
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void home_Load(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginfrom logifrom=new loginfrom();
            logifrom.ShowDialog();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Employeefrom employeefrom= new Employeefrom();
            this.Hide();
            employeefrom.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
                  Details details = new Details();
                  details.ShowDialog();
                  this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Salary salary=new Salary();
            salary.Show();
            this.Hide();
        }
    }
}


