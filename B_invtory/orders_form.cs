using B_invtory.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace B_invtory
{
    public partial class orders_form : Form
    {
        public static double sub_total=0;
        Order_db ordb = new Order_db();
        other_DB_tables other_table_db = new other_DB_tables();
        public orders_form()
        {
           

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            load_datas();
        }

        private void items_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void orders_form_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now.Date;
        }

        private void dil_ch_Click(object sender, EventArgs e)
        {

        }
        public void load_datas() {
            try
            {
                dele.Show();
                int id = int.Parse(textBox1.Text);
                Dictionary<string, object> data = ordb.select_All_from_order_id(id);
                if (data != null)
                {
                    cnc_order_btn.Visible = true;
                    c_pan.Visible = true;
                    bill_btn.Visible = true;
                    table_view.DataSource = other_table_db.data_table("SELECT orders.customer_id,customer.customer_name,"+
                        "product.product_id,product.product_name,product.price,"+
                        "product.size,orders.delived_date,orders.handover_date "
                    +"FROM bhuvani.orders,customer,product where orders.id_orders=" + id + " and"+
                    " orders.customer_id=customer.customer_id"+
                    " and orders.product_id=product.product_id;");
                    int stt = int.Parse(data["deliver_trace"].ToString());int qunity = int.Parse(data["qunity"].ToString()); double price = double.Parse(data["price"].ToString());
                    double sub_t = price * qunity;
                    cus_name.Text = data["customer_name"].ToString();qty_text.Text = data["qunity"].ToString();
                    pr_name.Text = data["product_name"].ToString();ordered_date.Text = data["order_recive_date"].ToString();
                    status_finder(stt); dil_ch.Text = data["delivery_charge"].ToString();
                    mn1_txt.Text = data["mobile1"].ToString(); mn2_txt.Text = data["mobile2"].ToString();
                    address_txt.Text = data["reciver_address"].ToString(); tt_txt.Text = data["total"].ToString();
                    subt_txt.Text = sub_t.ToString();
                }
                else {
                    clear();
                    bill_btn.Visible = false;
                    cnc_order_btn.Visible = false;
                }
            }
            catch (Exception ed) {
                clear();
                c_pan.Visible = false;
                cnc_order_btn.Visible = false;
            }
        
        }

        private void orders_form_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
            load_count_dash();
        }

        public void status_finder(int st) { 
           switch(st){
               case 0:
                   status.Text = "Processing";
                  pro_btn.Visible = false;
                  hand_btn.Visible = true;
                  dilver_btn.Visible = false;
                   dateTimePicker1.Visible = true;
                   break;
               case 1:
                   status.Text = "Handover to Couier";
                   dilver_btn.Visible = true;
                   hand_btn.Visible = false;
                   dateTimePicker1.Visible = true;
                   pro_btn.Visible = true;
                   break;
               case 2:
                   status.Text = "Delivered";
                   pro_btn.Visible = true;
                   hand_btn.Visible = true;
                   break;
               default:
                   pro_btn.Visible = false;
                   dilver_btn.Visible = false;
                   hand_btn.Visible = false;
                   break;
                   
                   
           }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string date = dateTimePicker1.Value.ToShortDateString();
            bool handover_order = ordb.update_handover(date, 2, id);
            if (handover_order == true)
            {
                MessageBox.Show("process the order");
                load_count_dash();
                load_datas();
            }
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void clear() {
           cus_name.Text = "";
           qty_text.Text = "";
           pr_name.Text = "";
           status.Text = "";
           ordered_date.Text = "";
            //
           dil_ch.Text = "0";
           mn1_txt.Text ="";
           mn2_txt.Text = "";
           address_txt.Text = "";
           tt_txt.Text = "";
           subt_txt.Text = "0";
           load_count_dash();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        public void load_count_dash(){
            pr_count_text.Text = other_table_db.get_counts("SELECT count(*) FROM bhuvani.orders where deliver_trace=0 ;", "count(*)").ToString();
            handover_count_txt.Text = other_table_db.get_counts("SELECT count(*) FROM bhuvani.orders where deliver_trace=1 ;", "count(*)").ToString();
            month_total_dil.Text = other_table_db.get_counts("SELECT count(*) FROM bhuvani.orders where month(delived_date)=month(current_timestamp());", "count(*)").ToString();
            table_view.DataSource = other_table_db.data_table("SELECT * FROM bhuvani.orders");


        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table_view.DataSource = other_table_db.data_table("SELECT * FROM bhuvani.orders where deliver_trace=0");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            table_view.DataSource = other_table_db.data_table("SELECT * FROM bhuvani.orders where deliver_trace=1");
        }

        private void hand_btn_Click(object sender, EventArgs e)
        {
            //set handover
            int id = int.Parse(textBox1.Text);
            string date=dateTimePicker1.Value.ToShortDateString();
            bool handover_order = ordb.update_handover(date, 1, id);
            if (handover_order == true) {
                MessageBox.Show("handover the order");
                load_count_dash();
                load_datas();
            }
        }

        private void pro_btn_Click(object sender, EventArgs e)
        {
            //Set process
            int id = int.Parse(textBox1.Text);
           // string date = dateTimePicker1.Value.ToShortDateString();
            bool handover_order = ordb.update_handover(null, 0, id);
            if (handover_order == true)
            {
                MessageBox.Show("process the order");
                load_count_dash();
                load_datas();
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table_view.DataSource = other_table_db.data_table("SELECT * FROM bhuvani.orders where month(delived_date)=month(current_timestamp());");
        }

        private void cnc_order_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
           bool del= ordb.delete_order_by_id(id);
           if (del == true) {
               MessageBox.Show("Order canceled");
           }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pr_count_text.Text = other_table_db.get_counts("SELECT count(*) FROM bhuvani.orders where deliver_trace=0 ;", "count(*)").ToString();
            handover_count_txt.Text = other_table_db.get_counts("SELECT count(*) FROM bhuvani.orders where deliver_trace=1 ;", "count(*)").ToString();
            month_total_dil.Text = other_table_db.get_counts("SELECT count(*) FROM bhuvani.orders where month(delived_date)=month(current_timestamp());", "count(*)").ToString();

        }

        private void bill_btn_Click(object sender, EventArgs e)
        {

        }

    }
}
