using B_invtory.DAO;
using B_invtory.databse;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace B_invtory.database
{
    class Order_db
    {
        static Sechema_Connection get_connection = Sechema_Connection.getIntance();
         public static MySqlConnection connection = get_connection.connection();
        public MySqlCommand cmb = null;
        Item_db_table_events itdb = new Item_db_table_events();

        public Dictionary<string,object>  select_All_from_order_id(int order_id)
        {
            MySqlDataReader reader = null;
            Dictionary<string, object> values = new Dictionary<string,object>();
            try
            {// id_orders, customer_id, distric_id, order_recive_date, product_id, qunity, deliver_trace, delived_date, 
                //reciver_address, delivery_charge, total, customer_id, customer_name, address, mobile1, mobile2,
                //distric_id, join_date, email, password, product_id, product_name, user_type_id, cat_id, 
                //image_path, about, size, price
                connection.Open();
                String inser_query = "SELECT * FROM bhuvani.orders,customer,product where orders.id_orders="+order_id+" and orders.customer_id=customer.customer_id and orders.product_id=product.product_id;";
               // connection.Open();
                cmb = new MySqlCommand(inser_query, connection);
                reader = cmb.ExecuteReader();
                while (reader.Read()) {
                    values.Add("order_recive_date", reader.GetString("order_recive_date"));
                    values.Add("customer_name", reader.GetString("customer_name"));
                    values.Add("product_name", reader.GetString("product_name"));
                    values.Add("mobile1", reader.GetString("mobile1"));
                    values.Add("mobile2", reader.GetString("mobile2"));
                    values.Add("reciver_address", reader.GetString("reciver_address"));
                    values.Add("delivery_charge", reader.GetDouble("delivery_charge"));
                    values.Add("total", reader.GetDouble("total"));
                    values.Add("price", reader.GetDouble("price"));
                    values.Add("qunity", reader.GetInt16("qunity"));
                    values.Add("deliver_trace", reader.GetInt16("deliver_trace"));

                }
                connection.Close();
                return values;
            }
            catch (MySqlException e)
            {
                connection.Close();
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool update_handover(String date,int value,int id)
        {
            try
            {
                String inser_query="";
                bool results = false;
                if (value == 1)
                {
                    //handover
inser_query = "Update orders set deliver_trace=1,"+
    "handover_date='" + date + "' where id_orders=" + id + ";";
                }
                else if (value == 2)
                {
                    //deliver
                    inser_query = "Update orders set deliver_trace=2,"+
                        "delived_date='" + date + "' where id_orders=" + id + ";";
                }
                else if (value == 0)
                {
                    //set as in  process
                    inser_query = "Update orders set deliver_trace=0,"+
                        "delived_date=null,handover_date=null where id_orders=" + id + ";";
                }
                else {
                    return false;
                }
         
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

        public bool delete_order_by_id(int id_)
        {
            //cancel order
            bool results = false;
            try
            {
               

                String inser_query = "Delete from  bhuvani.orders where id_orders=" + id_ + ";";
               
                    //results = false;
                    //MessageBox.Show("You can't Delete this Product because items are available for \n this producd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Query::" + inser_query);
                    bool item_up = itdb.set_null_items(id_);
                    if (item_up == false) { results = false; }
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
    
    }
}
