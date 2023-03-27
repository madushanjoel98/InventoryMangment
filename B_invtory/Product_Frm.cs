using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B_invtory.DAO;
using B_invtory.database;
using MySql.Data.MySqlClient;
using System.IO;
namespace B_invtory
{
    public partial class Product_Frm : Form
    {
        int file_handelers = 1;
        bool isCheck_product_edit_fun=false;
        Product_db_table product_dbs = new Product_db_table();
        Item_db_table_events item_db = new Item_db_table_events();
        other_DB_tables oth_db = new other_DB_tables();
        Stock_table stock_DB = new Stock_table();
        public Product_Frm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////insert product information
            if (validation_insert_product() == true)
            {
                Product_DOA prEntity = new Product_DOA();
                prEntity.Product_name = pr_name.Text;
                prEntity.Price = double.Parse(product_price.Value.ToString());

                prEntity.User_type = (int)user_gender.SelectedValue;
                prEntity.Cat_id = (int)cat_combo_box.SelectedValue;
                prEntity.About = prduct_about.Text;
                prEntity.Size = comboBox_size.SelectedItem.ToString();

                //Naming image filer
                string file_name = file_mover(pictureBox1.ImageLocation, pr_name.Text);
                prEntity.Image_path = file_name;

           
                //  MessageBox.Show(prEntity.Image_path, "Titel");

                bool insert = product_dbs.insert_product(prEntity);
                if (insert)
                {
                    clear_add_product_inputs();
                    MessageBox.Show("Successfully Inserted | ID:" + product_dbs.last_id, "Product");
                    refresh_dasher();
                }
            }
           

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            pictureBox1.ImageLocation = file.FileName;
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            DAO.Items_DAO item_d = new Items_DAO();
            Stock_DOA stocks = new Stock_DOA();

        int pr_id  = (int) combo_select_pr_id.SelectedValue;
      string date=item_recived_date.Value.ToShortDateString();
       int qunites=(int) qunity.Value;
      stocks.product_id = pr_id;
      stocks.qunity = qunites;
      stocks.recived_date = date;

if (stock_DB.insert(stocks))
{ //item insert
    item_d.recived_date =  stocks.recived_date;
    item_d.product_id = stocks.product_id;
    item_d.stock_id = stock_DB.last_id;
    for (int i = 0; i <qunites ; i++)
    {
        item_db.insert(item_d);
    }
    if (item_db.bulk_insert_catcher == true)
    {
        MessageBox.Show("item_inserted");
    }

}

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Product_Frm_Load(object sender, EventArgs e)
        {
            Total_counts_lbl.Text = product_dbs.count_of_product().ToString();
            //User gender
            user_gender.DataSource = oth_db.select_All_usersGenders_datasource();
            user_gender.DisplayMember = "Value";
            user_gender.ValueMember = "Key";
          
            dashbordvalues();
        }


        private void button4_Click(object sender, EventArgs e)
        {    
        }
        private void cat_combo_Click(object sender, EventArgs e)
        {
            //users of produtct combo box
            try
            {
                cat_combo_box.DataSource = oth_db.select_All_catagory_by_gender_datasource(int.Parse(user_gender.SelectedValue.ToString()));

                cat_combo_box.DisplayMember = "Value";
                cat_combo_box.ValueMember = "Key";
            }catch(Exception ex) {
                cat_combo_box.Text = "None";
                 }
        }

        private void user_gender_SelectedValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private String file_mover(string paths,string name) {
   
            String filename = utilities.Utils.file_name_create(name)+".jpg";
           
            if (File.Exists("F:\\Madushan\\document\\webdev\\BAUHINIA_store\\prImg\\" + name + ".jpg"))
            {
                filename = utilities.Utils.file_name_create(name) + ".jpg";
                File.Replace(paths, "F:\\Madushan\\document\\webdev\\BAUHINIA_store\\prImg\\" + name +"",null);
                return filename;
            }else {
               
             File.Copy(paths, "F:\\Madushan\\document\\webdev\\BAUHINIA_store\\prImg\\" + filename + "");
             return filename;
            } 
        
        }


        public bool validation_insert_product() {
            bool validation = true;
            if (pr_name.Text.Length == 0 || product_price.Value == null
                || prduct_about.Text.Length == 0 || pictureBox1.ImageLocation == null 
                || product_price.Value<0) {
                    MessageBox.Show("Can't Process, Please Check wheather the Inputs are empty","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    validation = false;
            
            }
            return validation;
        
        
        }

        public void clear_add_product_inputs() { 
        pr_name.Text="";
        product_price.Value = 0;
           prduct_about.Text="";
           pictureBox1.Image=null;
           
        
        }
        public void refresh_dasher() {
            Total_counts_lbl.Text = product_dbs.count_of_product().ToString();
        }

        

        public void hide_product_edit_del (bool function) {
            switch (function)
            {
                case false:
                    function = true;
                    search_produt_btn.Visible = function;
                    pr_id_txtbox.Visible = function;
                    label12.Visible = function;
                    button9.Visible = function;
                    button8.Visible = function;
                    insert_pr_btn.Visible = false;
                    break;
                case true:
                    function=false;
                    search_produt_btn.Visible = function;
                    pr_id_txtbox.Visible = function;
                    label12.Visible = function;
                    button9.Visible = function;
                    button8.Visible = function;
                    insert_pr_btn.Visible = true;
                    break;

            };
        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isCheck_product_edit_fun = radioButton1.Checked;
            if (radioButton1.Checked)
            {
                hide_product_edit_del(false);
            }
            else {
                hide_product_edit_del(true);
            }
            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && !isCheck_product_edit_fun)
            {
                radioButton1.Checked = false;
                
            }
            else
            {
                radioButton1.Checked = true;
                isCheck_product_edit_fun = false;
            }
        }

        public void load_product_data_by_id() {
            if (pr_id_txtbox.Text.Length != 0)
            {
                Product_DOA rd = product_dbs.select_product_by_id(int.Parse(pr_id_txtbox.Text));
                if (rd.Product_name != null)
                {
                    pr_name.Text = rd.Product_name;
                    pictureBox1.ImageLocation = "F:/Madushan/document/webdev/BAUHINIA_store/prImg/" + rd.Image_path;
                    user_gender.SelectedValue = rd.User_type;
                    cat_combo_box.SelectedValue = rd.Cat_id;
                    comboBox_size.SelectedItem = rd.Size;
                    product_price.Value = (decimal)rd.Price;
                    prduct_about.Text = rd.About;
                    cat_combo_box.Text = oth_db.cat_name_by_id(rd.Cat_id);
                }
                else { MessageBox.Show("Data not founed,Please check the Product ID"); }
            }
            else {
                MessageBox.Show("Please inter the Product ID");
            }

        }

        private void search_produt_btn_Click(object sender, EventArgs e)
        {
            load_product_data_by_id();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Update product
            Product_DOA prEntity = new Product_DOA();
            MessageBox.Show(cat_combo_box.SelectedValue.ToString());
            if (validation_update_product() == true)
                
            {
                prEntity.Product_id = int.Parse(pr_id_txtbox.Text);
                prEntity.Product_name = pr_name.Text;
                prEntity.Price = double.Parse(product_price.Value.ToString());
                prEntity.User_type = (int)user_gender.SelectedValue;
                prEntity.Cat_id = int.Parse(cat_combo_box.SelectedValue.ToString());
                prEntity.About = prduct_about.Text;
                prEntity.Size = comboBox_size.SelectedItem.ToString();
                //File.Delete("F:\\Madushan\\document\\webdev\\BAUHINIA_store\\prImg\\" + prEntity.Image_path); 
                // File.Replace("F:\\Madushan\\document\\webdev\\BAUHINIA_store\\prImg\\" + prEntity.Image_path, pictureBox1.ImageLocation, "C://");
                prEntity.Image_path = file_mover(pictureBox1.ImageLocation, prEntity.Product_name);
                bool upadate = product_dbs.update_product_by_id(prEntity);
                if (upadate == true)
                {
                    MessageBox.Show("Updated");

                }
            }
        }

        public bool validation_update_product()
        {
            bool validation = true;
            if(pr_id_txtbox.Text.Length==0){
                validation = false;
                MessageBox.Show("Can't Process, Please enter Product id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            if (pr_name.Text.Length == 0 || product_price.Value == null
                || prduct_about.Text.Length == 0 || pictureBox1.ImageLocation == null
                || product_price.Value < 0||cat_combo_box.Text=="")
            {
                MessageBox.Show("Can't Process, Please Check wheather the Inputs are empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validation = false;

            }
            return validation;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clear_add_product_inputs();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            int id=int.Parse( pr_id_txtbox.Text.ToString());
            if (pr_id_txtbox.Text.Length <= 0) { MessageBox.Show("Please enter thre Product id"); }
            else
            {
              bool del= product_dbs.delete_product_by_id(id);
              if (del) {
                  MessageBox.Show("Deleted");
              }

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

            combo_select_pr_id.DataSource = product_dbs.select_All_product_datasource();

            combo_select_pr_id.DisplayMember = "Value";
            combo_select_pr_id.ValueMember = "Key";

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
               int stockid=int.Parse( stock_id_txt.Text);
               int q = (int) qunity.Value;
            Stock_DOA da = new Stock_DOA();
            da.stock_id = stockid;
            da.qunity = q;
           stock_DB.update(da);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            int stockid = int.Parse(stock_id_txt.Text);
            stock_DB.delete(stockid);
        }

        private void pr_id_txtbox_TextChanged(object sender, EventArgs e)
        {
           load_product_data_by_id_for_text_change();
            //load_product_data_by_id();
        }


        public void load_product_data_by_id_for_text_change()
        {
            if (pr_id_txtbox.Text.Length != 0)
            {
                Product_DOA rd = product_dbs.select_product_by_id(int.Parse(pr_id_txtbox.Text));
                if (rd.Product_name != null)
                {
                    pr_name.Text = rd.Product_name;
                    pictureBox1.ImageLocation = "F:\\Madushan\\document\\webdev\\BAUHINIA_store\\prImg\\" + rd.Image_path;
                    user_gender.SelectedValue = rd.User_type;
                    cat_combo_box.SelectedValue = rd.Cat_id;
                    comboBox_size.SelectedItem = rd.Size;
                    product_price.Value = (decimal)rd.Price;
                    prduct_about.Text = rd.About;
                    cat_combo_box.Text = oth_db.cat_name_by_id(rd.Cat_id);
                }
                else {
                    clear_add_product_inputs();
                    //MessageBox.Show("Data not founed,Please check the Product ID"); 
                }
            }
            else
            {
                clear_add_product_inputs();
              //  MessageBox.Show("Please inter the Product ID");
            }

        }

        private void stock_id_txt_TextChanged(object sender, EventArgs e)
        {
            if (stock_id_txt.Text.Length == 0)
            {
                stock_update.Visible = false;
                stock_del.Visible = false;

            }
            else {
                stock_update.Visible = true;
                stock_del.Visible = true;
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    int p_id = int.Parse(textBox1.Text.ToString());
                    pr_gr_view.DataSource = oth_db.data_table("SELECT * FROM bhuvani.product where product_id=" + p_id + ";");
                    pr_available_items_lbl.Text = oth_db.get_counts("select count(*) as count from item where product_id="+p_id+" and availability is null or availability=0;", "count").ToString();
                }
                else {
                   pr_gr_view.DataSource=  oth_db.data_table("SELECT * FROM bhuvani.product;");
                   pr_available_items_lbl.Text = "0";
                }
            }
            catch (Exception ed) { 
            pr_gr_view.DataSource=  oth_db.data_table("SELECT * FROM bhuvani.product;");
            pr_available_items_lbl.Text = "0";
            
            }
        }

        private void pr_gr_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(pr_gr_view.SelectedCells.ToString());
        }


        public void dashbordvalues() {
            //Fill tables with data
            pr_gr_view.DataSource = oth_db.data_table("SELECT * FROM bhuvani.product;");
            stocks_grid.DataSource = oth_db.data_table("SELECT * FROM bhuvani.stocks;");
            all_item_count_lbl.Text = oth_db.get_counts("select count(*) as count from item;", "count")
                .ToString();

        }

        private void cat_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            stocks_grid.DataSource = oth_db.data_table("SELECT * FROM bhuvani.stocks;");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            stocks_grid.DataSource = oth_db.data_table("SELECT * FROM bhuvani.item;");
        }
      
    }
}
