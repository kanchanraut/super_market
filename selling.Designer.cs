namespace Supermarket__deskstop__application
{
    partial class Selling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selling));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_billid = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_qnty = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.cb_box = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.OrdersGDV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillsGDV = new System.Windows.Forms.DataGridView();
            this.productDGV = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbl_amt = new System.Windows.Forms.Label();
            this.lbl_rs = new System.Windows.Forms.Label();
            this.lbl_sellerelist = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button8 = new System.Windows.Forms.Button();
            this.lbl_sellnm = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsGDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Pink;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(521, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(417, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Selling Status";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_billid
            // 
            this.tb_billid.Location = new System.Drawing.Point(264, 71);
            this.tb_billid.Name = "tb_billid";
            this.tb_billid.Size = new System.Drawing.Size(201, 28);
            this.tb_billid.TabIndex = 5;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(264, 128);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(201, 28);
            this.tb_name.TabIndex = 6;
            // 
            // tb_qnty
            // 
            this.tb_qnty.Location = new System.Drawing.Point(264, 181);
            this.tb_qnty.Name = "tb_qnty";
            this.tb_qnty.Size = new System.Drawing.Size(201, 28);
            this.tb_qnty.TabIndex = 7;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(264, 241);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(201, 28);
            this.tb_price.TabIndex = 8;
            // 
            // cb_box
            // 
            this.cb_box.FormattingEnabled = true;
            this.cb_box.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.cb_box.Location = new System.Drawing.Point(163, 350);
            this.cb_box.Name = "cb_box";
            this.cb_box.Size = new System.Drawing.Size(189, 29);
            this.cb_box.TabIndex = 9;
            this.cb_box.Text = "Select category";
            this.cb_box.SelectedIndexChanged += new System.EventHandler(this.cb_box_SelectedIndexChanged);
            this.cb_box.SelectionChangeCommitted += new System.EventHandler(this.cb_box_SelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 595);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(17, 405);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 29);
            this.button9.TabIndex = 28;
            this.button9.Text = "HOME";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 338);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 29);
            this.button4.TabIndex = 24;
            this.button4.Text = "Selling";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 253);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 29);
            this.button6.TabIndex = 25;
            this.button6.Text = "Categories";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(17, 166);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 29);
            this.button7.TabIndex = 26;
            this.button7.Text = "Sellers";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // OrdersGDV
            // 
            this.OrdersGDV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrdersGDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Pname,
            this.Quantity,
            this.Price,
            this.TotalAmt});
            this.OrdersGDV.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.OrdersGDV.Location = new System.Drawing.Point(633, 55);
            this.OrdersGDV.Name = "OrdersGDV";
            this.OrdersGDV.Size = new System.Drawing.Size(547, 171);
            this.OrdersGDV.TabIndex = 12;
            this.OrdersGDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ProdcID";
            this.ID.Name = "ID";
            // 
            // Pname
            // 
            this.Pname.HeaderText = "ProdName";
            this.Pname.Name = "Pname";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // TotalAmt
            // 
            this.TotalAmt.HeaderText = "TotalAmt";
            this.TotalAmt.Name = "TotalAmt";
            // 
            // BillsGDV
            // 
            this.BillsGDV.AllowUserToAddRows = false;
            this.BillsGDV.AllowUserToOrderColumns = true;
            this.BillsGDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillsGDV.Location = new System.Drawing.Point(633, 313);
            this.BillsGDV.Name = "BillsGDV";
            this.BillsGDV.ReadOnly = true;
            this.BillsGDV.Size = new System.Drawing.Size(547, 176);
            this.BillsGDV.TabIndex = 13;
            this.BillsGDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillsGDV_CellContentClick);
            // 
            // productDGV
            // 
            this.productDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDGV.Location = new System.Drawing.Point(163, 432);
            this.productDGV.Name = "productDGV";
            this.productDGV.Size = new System.Drawing.Size(245, 165);
            this.productDGV.TabIndex = 14;
            this.productDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDGV_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "Add Product";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Addprod_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(664, 529);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 29);
            this.button3.TabIndex = 16;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(810, 529);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(90, 29);
            this.btn_print.TabIndex = 17;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(970, 529);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 29);
            this.button5.TabIndex = 18;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1052, 14);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 21);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Date";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lbl_amt
            // 
            this.lbl_amt.AutoSize = true;
            this.lbl_amt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amt.Location = new System.Drawing.Point(677, 241);
            this.lbl_amt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_amt.Name = "lbl_amt";
            this.lbl_amt.Size = new System.Drawing.Size(93, 21);
            this.lbl_amt.TabIndex = 21;
            this.lbl_amt.Text = "Amount Rs";
            this.lbl_amt.Click += new System.EventHandler(this.lbl_amt_Click);
            // 
            // lbl_rs
            // 
            this.lbl_rs.AutoSize = true;
            this.lbl_rs.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rs.Location = new System.Drawing.Point(806, 241);
            this.lbl_rs.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_rs.Name = "lbl_rs";
            this.lbl_rs.Size = new System.Drawing.Size(31, 21);
            this.lbl_rs.TabIndex = 22;
            this.lbl_rs.Text = " Rs";
            // 
            // lbl_sellerelist
            // 
            this.lbl_sellerelist.AutoSize = true;
            this.lbl_sellerelist.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sellerelist.Location = new System.Drawing.Point(874, 289);
            this.lbl_sellerelist.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_sellerelist.Name = "lbl_sellerelist";
            this.lbl_sellerelist.Size = new System.Drawing.Size(79, 21);
            this.lbl_sellerelist.TabIndex = 23;
            this.lbl_sellerelist.Text = " Sells List";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printdocoment);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1215, 10);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(37, 29);
            this.button8.TabIndex = 28;
            this.button8.Text = "X";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // lbl_sellnm
            // 
            this.lbl_sellnm.AutoSize = true;
            this.lbl_sellnm.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sellnm.Location = new System.Drawing.Point(169, 10);
            this.lbl_sellnm.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_sellnm.Name = "lbl_sellnm";
            this.lbl_sellnm.Size = new System.Drawing.Size(99, 21);
            this.lbl_sellnm.TabIndex = 29;
            this.lbl_sellnm.Text = "SellerName";
            // 
            // Selling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.lbl_sellnm);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.lbl_sellerelist);
            this.Controls.Add(this.lbl_rs);
            this.Controls.Add(this.lbl_amt);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.productDGV);
            this.Controls.Add(this.BillsGDV);
            this.Controls.Add(this.OrdersGDV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_box);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_qnty);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_billid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Selling";
            this.Text = "Selling";
            this.Load += new System.EventHandler(this.Selling_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsGDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_billid;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_qnty;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.ComboBox cb_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView OrdersGDV;
        private System.Windows.Forms.DataGridView BillsGDV;
        private System.Windows.Forms.DataGridView productDGV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lbl_amt;
        private System.Windows.Forms.Label lbl_rs;
        private System.Windows.Forms.Label lbl_sellerelist;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmt;
        private System.Windows.Forms.Label lbl_sellnm;
    }
}