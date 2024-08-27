using Supermarket__deskstop__application;
using System;
using System.Windows.Forms;

namespace Supermarket_deskstop_application
{
    public partial class Homefrom : Form
    {
        public Homefrom()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller();
            seller.ShowDialog();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.ShowDialog();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
          
                Selling selling = new Selling();
                selling.ShowDialog();
            this.Hide();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }
    }
}
