using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket__deskstop__application
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //startpoint += 1;
            //Myprogressbar.Value = startpoint;
            //if (Myprogressbar.Value == 100)
            //{
            //    Myprogressbar.Value = 0;
            //    timer1.Stop();
            //    Form1 form1 = new Form1();
            //    this.Hide();
            //    form1.Show();
            //}
        }
        private void Splash_Load(object sender, EventArgs e)
        {
            //timer2.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Myprogressbar_Click(object sender, EventArgs e)
        {


        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBar1.Value = startpoint;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer2.Stop();
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
        }
        private void Splash_Load_1(object sender, EventArgs e)
        {
            timer2.Start();

        }
        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
