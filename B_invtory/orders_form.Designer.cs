namespace B_invtory
{
    partial class orders_form
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dele = new System.Windows.Forms.TabPage();
            this.bill_btn = new System.Windows.Forms.Button();
            this.cnc_order_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.status = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.qty_text = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ordered_date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pr_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.address_txt = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mn2_txt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mn1_txt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cus_name = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tt_txt = new System.Windows.Forms.Label();
            this.subt_txt = new System.Windows.Forms.Label();
            this.dil_ch = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.c_pan = new System.Windows.Forms.Panel();
            this.pro_btn = new System.Windows.Forms.Button();
            this.dilver_btn = new System.Windows.Forms.Button();
            this.hand_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.table_view = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pr_count_text = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.month_total_dil = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.handover_count_txt = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.dele.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.c_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_view)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dele);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(222, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(857, 592);
            this.tabControl1.TabIndex = 1;
            // 
            // dele
            // 
            this.dele.AutoScroll = true;
            this.dele.Controls.Add(this.bill_btn);
            this.dele.Controls.Add(this.cnc_order_btn);
            this.dele.Controls.Add(this.panel2);
            this.dele.Controls.Add(this.groupBox1);
            this.dele.Controls.Add(this.panel6);
            this.dele.Controls.Add(this.c_pan);
            this.dele.Controls.Add(this.label1);
            this.dele.Controls.Add(this.table_view);
            this.dele.Controls.Add(this.textBox1);
            this.dele.Location = new System.Drawing.Point(4, 22);
            this.dele.Name = "dele";
            this.dele.Padding = new System.Windows.Forms.Padding(3);
            this.dele.Size = new System.Drawing.Size(849, 566);
            this.dele.TabIndex = 0;
            this.dele.Text = "Order";
            this.dele.UseVisualStyleBackColor = true;
            this.dele.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // bill_btn
            // 
            this.bill_btn.BackColor = System.Drawing.Color.Fuchsia;
            this.bill_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bill_btn.Location = new System.Drawing.Point(469, 250);
            this.bill_btn.Name = "bill_btn";
            this.bill_btn.Size = new System.Drawing.Size(98, 29);
            this.bill_btn.TabIndex = 14;
            this.bill_btn.TabStop = false;
            this.bill_btn.Text = "Print Bill";
            this.bill_btn.UseVisualStyleBackColor = false;
            this.bill_btn.Visible = false;
            this.bill_btn.Click += new System.EventHandler(this.bill_btn_Click);
            // 
            // cnc_order_btn
            // 
            this.cnc_order_btn.BackColor = System.Drawing.Color.Red;
            this.cnc_order_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cnc_order_btn.Location = new System.Drawing.Point(365, 250);
            this.cnc_order_btn.Name = "cnc_order_btn";
            this.cnc_order_btn.Size = new System.Drawing.Size(98, 29);
            this.cnc_order_btn.TabIndex = 4;
            this.cnc_order_btn.TabStop = false;
            this.cnc_order_btn.Text = "Cancel the order";
            this.cnc_order_btn.UseVisualStyleBackColor = false;
            this.cnc_order_btn.Visible = false;
            this.cnc_order_btn.Click += new System.EventHandler(this.cnc_order_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.status);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.qty_text);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.ordered_date);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pr_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(9, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 133);
            this.panel2.TabIndex = 13;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(86, 105);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(23, 13);
            this.status.TabIndex = 8;
            this.status.Text = "null";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Status:";
            // 
            // qty_text
            // 
            this.qty_text.AutoSize = true;
            this.qty_text.Location = new System.Drawing.Point(86, 75);
            this.qty_text.Name = "qty_text";
            this.qty_text.Size = new System.Drawing.Size(23, 13);
            this.qty_text.TabIndex = 7;
            this.qty_text.Text = "null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Qunity:";
            // 
            // ordered_date
            // 
            this.ordered_date.AutoSize = true;
            this.ordered_date.Location = new System.Drawing.Point(86, 45);
            this.ordered_date.Name = "ordered_date";
            this.ordered_date.Size = new System.Drawing.Size(23, 13);
            this.ordered_date.TabIndex = 6;
            this.ordered_date.Text = "null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ordered date";
            // 
            // pr_name
            // 
            this.pr_name.AutoSize = true;
            this.pr_name.Location = new System.Drawing.Point(86, 15);
            this.pr_name.Name = "pr_name";
            this.pr_name.Size = new System.Drawing.Size(23, 13);
            this.pr_name.TabIndex = 5;
            this.pr_name.Text = "null";
            this.pr_name.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.address_txt);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.mn2_txt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.mn1_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cus_name);
            this.groupBox1.Location = new System.Drawing.Point(356, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 238);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(9, 121);
            this.address_txt.Name = "address_txt";
            this.address_txt.ReadOnly = true;
            this.address_txt.Size = new System.Drawing.Size(241, 95);
            this.address_txt.TabIndex = 10;
            this.address_txt.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "mobile no2:";
            // 
            // mn2_txt
            // 
            this.mn2_txt.AutoSize = true;
            this.mn2_txt.Location = new System.Drawing.Point(92, 76);
            this.mn2_txt.Name = "mn2_txt";
            this.mn2_txt.Size = new System.Drawing.Size(23, 13);
            this.mn2_txt.TabIndex = 8;
            this.mn2_txt.Text = "null";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "mobile no1:";
            // 
            // mn1_txt
            // 
            this.mn1_txt.AutoSize = true;
            this.mn1_txt.Location = new System.Drawing.Point(92, 54);
            this.mn1_txt.Name = "mn1_txt";
            this.mn1_txt.Size = new System.Drawing.Size(23, 13);
            this.mn1_txt.TabIndex = 6;
            this.mn1_txt.Text = "null";
            this.mn1_txt.Click += new System.EventHandler(this.label10_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Custome name:";
            // 
            // cus_name
            // 
            this.cus_name.AutoSize = true;
            this.cus_name.Location = new System.Drawing.Point(92, 29);
            this.cus_name.Name = "cus_name";
            this.cus_name.Size = new System.Drawing.Size(23, 13);
            this.cus_name.TabIndex = 4;
            this.cus_name.Text = "null";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tt_txt);
            this.panel6.Controls.Add(this.subt_txt);
            this.panel6.Controls.Add(this.dil_ch);
            this.panel6.Controls.Add(this.total);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(618, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(214, 118);
            this.panel6.TabIndex = 11;
            // 
            // tt_txt
            // 
            this.tt_txt.AutoSize = true;
            this.tt_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_txt.Location = new System.Drawing.Point(98, 76);
            this.tt_txt.Name = "tt_txt";
            this.tt_txt.Size = new System.Drawing.Size(19, 20);
            this.tt_txt.TabIndex = 15;
            this.tt_txt.Text = "0";
            // 
            // subt_txt
            // 
            this.subt_txt.AutoSize = true;
            this.subt_txt.Location = new System.Drawing.Point(98, 42);
            this.subt_txt.Name = "subt_txt";
            this.subt_txt.Size = new System.Drawing.Size(13, 13);
            this.subt_txt.TabIndex = 14;
            this.subt_txt.Text = "0";
            // 
            // dil_ch
            // 
            this.dil_ch.AutoSize = true;
            this.dil_ch.Location = new System.Drawing.Point(98, 20);
            this.dil_ch.Name = "dil_ch";
            this.dil_ch.Size = new System.Drawing.Size(13, 13);
            this.dil_ch.TabIndex = 10;
            this.dil_ch.Text = "0";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(58, 76);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(34, 13);
            this.total.TabIndex = 13;
            this.total.Text = "Total:";
            this.total.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sub Total:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dilivery charges:";
            // 
            // c_pan
            // 
            this.c_pan.Controls.Add(this.pro_btn);
            this.c_pan.Controls.Add(this.dilver_btn);
            this.c_pan.Controls.Add(this.hand_btn);
            this.c_pan.Controls.Add(this.dateTimePicker1);
            this.c_pan.Location = new System.Drawing.Point(6, 187);
            this.c_pan.Name = "c_pan";
            this.c_pan.Size = new System.Drawing.Size(347, 104);
            this.c_pan.TabIndex = 9;
            this.c_pan.Visible = false;
            // 
            // pro_btn
            // 
            this.pro_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pro_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pro_btn.Location = new System.Drawing.Point(127, 62);
            this.pro_btn.Name = "pro_btn";
            this.pro_btn.Size = new System.Drawing.Size(104, 29);
            this.pro_btn.TabIndex = 3;
            this.pro_btn.TabStop = false;
            this.pro_btn.Text = "Set Process";
            this.pro_btn.UseVisualStyleBackColor = false;
            this.pro_btn.Visible = false;
            this.pro_btn.Click += new System.EventHandler(this.pro_btn_Click);
            // 
            // dilver_btn
            // 
            this.dilver_btn.BackColor = System.Drawing.Color.Lime;
            this.dilver_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dilver_btn.Location = new System.Drawing.Point(237, 62);
            this.dilver_btn.Name = "dilver_btn";
            this.dilver_btn.Size = new System.Drawing.Size(98, 29);
            this.dilver_btn.TabIndex = 2;
            this.dilver_btn.TabStop = false;
            this.dilver_btn.Text = "Deliverd";
            this.dilver_btn.UseVisualStyleBackColor = false;
            this.dilver_btn.Visible = false;
            this.dilver_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // hand_btn
            // 
            this.hand_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.hand_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hand_btn.Location = new System.Drawing.Point(17, 62);
            this.hand_btn.Name = "hand_btn";
            this.hand_btn.Size = new System.Drawing.Size(104, 29);
            this.hand_btn.TabIndex = 1;
            this.hand_btn.TabStop = false;
            this.hand_btn.Text = "Handover";
            this.hand_btn.UseVisualStyleBackColor = false;
            this.hand_btn.Visible = false;
            this.hand_btn.Click += new System.EventHandler(this.hand_btn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(301, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order id";
            // 
            // table_view
            // 
            this.table_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.table_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.table_view.Location = new System.Drawing.Point(3, 297);
            this.table_view.Name = "table_view";
            this.table_view.Size = new System.Drawing.Size(843, 266);
            this.table_view.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.pr_count_text);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 138);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(37, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show on Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pr_count_text
            // 
            this.pr_count_text.AutoSize = true;
            this.pr_count_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pr_count_text.Location = new System.Drawing.Point(89, 50);
            this.pr_count_text.Name = "pr_count_text";
            this.pr_count_text.Size = new System.Drawing.Size(37, 39);
            this.pr_count_text.TabIndex = 1;
            this.pr_count_text.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Processing orders";
            this.label10.Click += new System.EventHandler(this.label10_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 592);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.month_total_dil);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 335);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 257);
            this.panel4.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(37, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 22);
            this.button4.TabIndex = 10;
            this.button4.Text = "Show on Table";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(89, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 39);
            this.label12.TabIndex = 9;
            this.label12.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Total deliveries";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(37, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 22);
            this.button3.TabIndex = 6;
            this.button3.Text = "Show on Table";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // month_total_dil
            // 
            this.month_total_dil.AutoSize = true;
            this.month_total_dil.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_total_dil.Location = new System.Drawing.Point(89, 40);
            this.month_total_dil.Name = "month_total_dil";
            this.month_total_dil.Size = new System.Drawing.Size(37, 39);
            this.month_total_dil.TabIndex = 7;
            this.month_total_dil.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "This months total deliveries";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Yellow;
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.handover_count_txt);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 138);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(222, 197);
            this.panel5.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(37, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 22);
            this.button2.TabIndex = 5;
            this.button2.Text = "Show on Table";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // handover_count_txt
            // 
            this.handover_count_txt.AutoSize = true;
            this.handover_count_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handover_count_txt.Location = new System.Drawing.Point(89, 54);
            this.handover_count_txt.Name = "handover_count_txt";
            this.handover_count_txt.Size = new System.Drawing.Size(37, 39);
            this.handover_count_txt.TabIndex = 4;
            this.handover_count_txt.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(78, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Handovers";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // orders_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1079, 592);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "orders_form";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.orders_form_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.dele.ResumeLayout(false);
            this.dele.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.c_pan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_view)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dele;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView table_view;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Panel c_pan;
        private System.Windows.Forms.Button pro_btn;
        private System.Windows.Forms.Button dilver_btn;
        private System.Windows.Forms.Button hand_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label cus_name;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label qty_text;
        private System.Windows.Forms.Label ordered_date;
        private System.Windows.Forms.Label pr_name;
        private System.Windows.Forms.Label dil_ch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label mn2_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label mn1_txt;
        private System.Windows.Forms.RichTextBox address_txt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label tt_txt;
        private System.Windows.Forms.Label subt_txt;
        private System.Windows.Forms.Label pr_count_text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label handover_count_txt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label month_total_dil;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button cnc_order_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bill_btn;
    }
}