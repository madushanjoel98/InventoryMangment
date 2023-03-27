using B_invtory.DAO;
using B_invtory.databse;
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


namespace B_invtory.database
{
    class Product_db_table
    {
        public int last_id { get; set; }


        static Sechema_Connection get_connection = Sechema_Connection.getIntance();
        public MySqlConnection connection = get_connection.connection();
        public MySqlCommand cmb = null;

        public bool insert_product(Product_DOA pr_en)
        {
            try
            {
                bool results = false;
  String inser_query = "INSERT INTO product (product_name,user_type_id, cat_id, image_path, about,size,price)"
                + "VALUES('" + pr_en.Product_name + "','" + pr_en.User_type + "','" + pr_en.Cat_id + "','" + pr_en.Image_path + "','" + pr_en.About + "','" + pr_en.Size + "','" + pr_en.Price + "');";
                Console.WriteLine(inser_query);
                connection.Open();

                cmb = new MySqlCommand(inser_query, connection);

                if (cmb.ExecuteNonQuery() > 0)
                {
                    last_id = (int)cmb.LastInsertedId;
                    connection.Close();
                    results = true;
                }

                return results;
            }
            catch (MySqlException e)
            {
                connection.Close();
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool update_product_by_id(Product_DOA pr_en)
        {
            try
            {
                bool results = false;
String inser_query = "Update product set product_name='" + pr_en.Product_name + "', user_type_id='" + pr_en.User_type + "',"
    +" cat_id='" + pr_en.Cat_id + "', image_path='" + pr_en.Image_path + "', about='" + pr_en.About + "'"+
    ", size='" + pr_en.Size + "',price='"+pr_en.Price+"' where product_id='" + pr_en.Product_id + "';";
                Console.WriteLine("Query::" + inser_query);
                connection.Open();
                cmb = new MySqlCommand(inser_query, connection);

                if (cmb.ExecuteNonQuery() == 1)
                {
                    connection.Close();
                    results = true;
                }

                return results;
            }
            catch (MySqlException e)
            {
                connection.Close();
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public int count_of_product()
        {
            int counts = 0;
            MySqlDataReader reader = null;
            try
            {
               
                String inser_query = "SELECT COUNT(*) as prcount from product";
                connection.Open();
                cmb = new MySqlCommand(inser_query, connection);
                reader = cmb.ExecuteReader();
                while (reader.Read())
                {
                    counts = reader.GetInt16("prcount"); ;
                }
                connection.Close();

                return counts;


            }
            catch (MySqlException e)
            {
                connection.Close();
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return counts;
            }
        }

        public String get_product_image_file_name(int id)
        {
            String result = null;
            MySqlDataReader reader = null;
            try
            {
                bool results = false;
                String inser_query = "SELECT image_path FROM bhuvani.product where product_id=" + id + ";";
                connection.Open();
                cmb = new MySqlCommand(inser_query, connection);
                reader = cmb.ExecuteReader();
                while (reader.Read())
                {
                    result = reader.GetString("image_path"); ;
                }
                connection.Close();

                return result;


            }
            catch (MySqlException e)
            {
                connection.Close();
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }



        }

        public Product_DOA select_product_by_id(int id)
        {
            Product_DOA ser = new Product_DOA();
            MySqlDataReader reader = null;
            try
            {

                String inser_query = "SELECT * FROM bhuvani.product where product_id ="+id+";";
                connection.Open();
                cmb = new MySqlCommand(inser_query, connection);
                reader = cmb.ExecuteReader();
                while (reader.Read()) {
                    ser.Product_name = reader.GetString("product_name");
                    ser.User_type = reader.GetInt16("user_type_id");
                    ser.Size = reader.GetString("size");
                    ser.Image_path = reader.GetString("image_path");
                    ser.Price = reader.GetDouble("price");
                    ser.About = reader.GetString("about");
                    ser.Cat_id = reader.GetInt16("cat_id");

                }
                connection.Close();
                return ser;
            }
            catch (MySqlException e)
            {
                connection.Close();
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ser;
            }
        }

        public bool delete_product_by_id(int id_)
        {
            bool results = false;
            try
            {
                String inser_query = "Delete from  bhuvani.product where product_id="+id_+";";
                if (check_item_available_in_product(id_) == true) {
                //Validation: product have stocks;
                    results=false;
     MessageBox.Show("You can't Delete this Product because items are available for \n this producd", "Error",
         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    Console.WriteLine("Query::" + inser_query);
                    connection.Open();
                    cmb = new MySqlCommand(inser_query, connection);

                    if (cmb.ExecuteNonQuery() == 1)
                    {
                        connection.Close();
                        results = true;
                    }
                }
                return results;
            }
            catch (MySqlException e)
            {
                connection.Close();
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public BindingSource select_All_product_datasource()
        {
 
            BindingSource source = null;
            Dictionary <int, int> users = new Dictionary<int, int>();
            MySqlDataReader reader = null;
            try
            {
                bool results = false;
                String inser_query = "Select * from product;";
                connection.Open();
                cmb = new MySqlCommand(inser_query, connection);
                reader = cmb.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(reader.GetInt16("product_id"), reader.GetInt16("product_id"));
                }
                connection.Close();
                source = new BindingSource(users, null);

                return source;


            }
            catch (MySqlException e)
            {
                connection.Close();
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return source;
            }


        }

        public bool check_item_available_in_product(int pr_id)
        {
            try
            {
                bool results = false;
                String inser_query = "SELECT * FROM bhuvani.item where product_id=" + pr_id + "";
                connection.Open();
                cmb = new MySqlCommand(inser_query, connection);
                MySqlDataReader reader = cmb.ExecuteReader();
                if (reader.Read())
                {
                    results = true;
                    Console.WriteLine(reader.GetString("item_id"));

                    connection.Close();

                }
                connection.Close();
                return results;
            }
            catch (MySqlException e)
            {
                connection.Close();
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


      
       
    }
}