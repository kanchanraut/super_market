using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Supermarket_deskstop_application;

namespace Supermarket__deskstop__application
{
    public partial class Selling : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["mystring"].ConnectionString;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Selling()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Selling_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            FillCategory();
            //tb_sellernm.Text = string.Empty/*;*/


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Categories cat =new Categories();
            cat.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void BillsGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lblDate.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        int flag = 0;
        private void productDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_name.Text = productDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_qnty.Text = productDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void populate()
        {
            con = new SqlConnection(cs);
            string query = "select prodName ,prodqty from tbl_product";
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            SqlCommandBuilder billder = new SqlCommandBuilder(ad);
            var ds = new DataSet();
            ad.Fill(ds);
            productDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        public void populatebills()
        {
            con = new SqlConnection(cs);
            string query = "select*from tbl_bill";
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(ad);
            var ds = new DataSet();
            ad.Fill(ds);
            BillsGDV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void button3_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(tb_billid.Text))
            {
                MessageBox.Show("Missing Bill ID");
                return;
            }

            int billId;
            if (!int.TryParse(tb_billid.Text, out billId))
            {
                MessageBox.Show("Bill ID must be a valid integer");
                return;
            }


            string SellerName=lbl_sellnm.Text;
            int totalAmount;
            if (!int.TryParse(lbl_amt.Text, out totalAmount))
            {
                MessageBox.Show("Total Amount must be a valid number in the correct format (e.g., 1234.56)");
                return;
            }

            //decimal totalAmount;
            //if (!decimal.TryParse(lbl_amt.Text, out totalAmount))
            //{
            //    MessageBox.Show("Total Amount must be a valid integer");
            //    return;
            //}

            DateTime billDate;
            if (!DateTime.TryParse(lblDate.Text, out billDate))
            {
                MessageBox.Show("Bill Date must be a valid date");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO tbl_bill (BillID, SellerName, BillDate, TotalAmount) VALUES (@BillID, @SellerName, @BillDate, @TotalAmount)", con))
                    {
                        cmd.Parameters.AddWithValue("@BillID", billId);
                        cmd.Parameters.AddWithValue("@SellerName",SellerName);
                        cmd.Parameters.AddWithValue("@BillDate", billDate);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Order added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                populatebills();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //    if (tb_billid.Text == "")
        //    {
        //        MessageBox.Show("missing Bill id");
        //    }
        //    else
        //    {
        //        try
        //        {
        //            con.Open();
        //            con = new SqlConnection(cs);
        //            //cmd = new sqlCommand("insert into tbl_bill values("+tb_billid.text+",'"+lbl_sellernm.text+"','"+lbldate.text+"',"+lbl_amt.text+")", con);
        //            string query = "INSERT INTO tbl_bill (BillID, SellerName, BillDate, TotalAmount) VALUES (@BilLID, @SellerName, @BillDate, @TotAmt)";
        //            cmd.Parameters.AddWithValue("@BilLID", Convert.ToInt32(tb_billid.Text));
        //            cmd.Parameters.AddWithValue("@SellerName", lbl_sellernm.Text);
        //            cmd.Parameters.AddWithValue("@BillDate", lblDate.Text);
        //            cmd.Parameters.AddWithValue("@TotAmt", Convert.ToInt32(lbl_amt.Text));          
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("order Add Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            con.Close();
        //            populatebills();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //}
        private void btn_print_Click(object sender, EventArgs e)
        {


            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printdocoment);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            //if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    //this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1.PrintPage);

            //    printDocument1.Print();
            //}
        }
        private void FillCategory()
        {
            //this method will bind the combobox with the database
            
            con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select cateName from tbl_categories", con);
            con.Open();
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("cateName", typeof(string));
            dt.Load(rdr);
            cb_box.ValueMember = "cateName";
            cb_box.DataSource = dt;
            con.Close();
        }

        //int n;
        private void printdocoment(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            if (BillsGDV.SelectedRows.Count > 0)
            {
                // Printing the header
                e.Graphics.DrawString("SuperMarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230, 30));

                // Printing Bill ID
                e.Graphics.DrawString("Bill ID: " + BillsGDV.SelectedRows[0].Cells["BillID"].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Blue, new Point(100, 100));

                // Printing Seller Name
                e.Graphics.DrawString("Seller Name: " + BillsGDV.SelectedRows[0].Cells["SellerName"].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Blue, new Point(100, 150));

                // Printing Bill Date
                e.Graphics.DrawString("Bill Date: " + BillsGDV.SelectedRows[0].Cells["BillDate"].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Blue, new Point(100, 200));

                // Printing Total Amount
                e.Graphics.DrawString("Total Amount: " + BillsGDV.SelectedRows[0].Cells["TotalAmount"].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Blue, new Point(100, 250));

                // Printing footer
                e.Graphics.DrawString("Technology", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230, 300));
            }
            else
            {
                e.Graphics.DrawString("No row selected.", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(100, 100));
            }
        
       
            //e.Graphics.DrawString("SuperMarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            //e.Graphics.DrawString("Bill ID:" + BillsGDV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold),
            //    Brushes.Blue, new Point(100, 100));
            //e.Graphics.DrawString("Seller Name:" + BillsGDV.SelectedRows[1].Cells[0].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold),
            //    Brushes.Blue, new Point(100, 100));
            //e.Graphics.DrawString(" Bill Date:" + BillsGDV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold),
            //                Brushes.Blue, new Point(100, 130));
            //e.Graphics.DrawString(" Total Amount" + BillsGDV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold),
            //                Brushes.Blue, new Point(100, 160));
            //e.Graphics.DrawString("Technology", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230, 230));
        }

        private void Addprod_Click(object sender, EventArgs e)
        {
            try
            {
               int grdTotal = 0 ,n=0;
           
                if (tb_name.Text == "" || tb_qnty.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }

                else
                {
                    int total = Convert.ToInt32(tb_price.Text) * Convert.ToInt32(tb_qnty.Text);
                    DataGridViewRow viewRow = new DataGridViewRow();
                    viewRow.CreateCells(OrdersGDV);
                    viewRow.Cells[0].Value = n + 1;
                    viewRow.Cells[1].Value = tb_name.Text;
                    viewRow.Cells[2].Value = tb_qnty.Text;
                    viewRow.Cells[3].Value = Convert.ToInt32(tb_price.Text);
                    viewRow.Cells[4].Value = Convert.ToInt32(tb_price.Text) * Convert.ToInt32(tb_qnty.Text);
                    OrdersGDV.Rows.Add(viewRow);
                    n++;
                    grdTotal = grdTotal + total;
                    lbl_amt.Text = "Rs" + grdTotal;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Seller seller= new Seller();
            seller.ShowDialog();
            this.Hide();
        }
        private void button9_Click(object sender, EventArgs e)
        {

            Homefrom home=new Homefrom();
            home.ShowDialog();
            this.Hide();
        }
        private void lblDate_Click(object sender, EventArgs e)
        {


        }
        private void lbl_amt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void cb_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_box_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string selectedCategory = cb_box.SelectedValue.ToString();
                    MessageBox.Show("Selected Category: " + selectedCategory); // Debugging line
                    string query = "SELECT prodName, prodQty FROM tbl_product WHERE prodCat = @prodCat";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@prodCat", selectedCategory);
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        productDGV.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //con.Open();
        //string query = "select prodName ,prodqty from tbl_product where prodcat='"+cb_box.SelectedValue.ToString()+"'";
        //SqlDataAdapter da = new SqlDataAdapter(query, con);
        //SqlCommandBuilder builder = new SqlCommandBuilder(da);
        //var ds= new DataSet();
        //da.Fill(ds);
        //productDGV.DataSource = ds.Tables[0];
        //con.Close();
    
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs);
                cmd = new SqlCommand("Delete from tbl_bill where @BillID=BillID", con);
                cmd.Parameters.AddWithValue("@BillID", tb_billid.Text);
                con.Open();
                MessageBox.Show("DATA delete Successfully", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                tb_billid.Text = "";
                lbl_sellnm.Text = "";
                lbl_amt.Text = "";
                lblDate.Text = "";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbl_sellernm_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}










