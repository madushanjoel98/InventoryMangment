using B_invtory.DAO;
using B_invtory.databse;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
namespace B_invtory.database
{
    class Item_db_table_events
    {
        public int last_id { get; set; }
        static Sechema_Connection get_connection = Sechema_Connection.getIntance();
        private  static MySqlConnection connection = get_connection.connection();
        public  MySqlCommand cmb = null;

        public bool bulk_insert_catcher = false;


     public bool insert(Items_DAO items)
        {
            try
            {
                bool results = false;
                String inser_query = "INSERT INTO item (product_id, stock_id,availability)"
                    + "VALUES('" + items.product_id + "','" + items.stock_id+ "',1);";

                Console.WriteLine(inser_query);
                connection.Open();

                cmb = new MySqlCommand(inser_query, connection);

                if (cmb.ExecuteNonQuery() > 0)
                {
                    last_id = (int)cmb.LastInsertedId;
                    connection.Close();
                    bulk_insert_catcher = true;
                    results = true;
                }

                return results;
            }
            catch (MySqlException e)
            {
                connection.Close();
                bulk_insert_catcher = false;
                MessageBox.Show("Cant process the insert statment please check wheather product id was correct or values"
                    +"\n "+e.ToString(), "Error Item insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


//throw new NotImplementedException();
        }

     public bool set_null_items(int order_id)
     {
         try
         {
             bool results = false;
             String inser_query = "Update item set availability=1,order_id=null where order_id="+order_id+"; ";
             Console.WriteLine("Query::" + inser_query);
             connection.Open();
             cmb = new MySqlCommand(inser_query, connection);

             if (cmb.ExecuteNonQuery() == 1)
             {
                 
                 results = true;
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

        public bool delete()
        {
            throw new NotImplementedException();
        }

        public  int count_of_available_item_by_stock_id(int stock_id)
        {
            int counts = 0;
            MySqlDataReader reader = null;
            try
            {

                String inser_query = "select count(*) from item where stock_id="+stock_id+" and availability is null or availability=1;";
                connection.Open();
                cmb = new MySqlCommand(inser_query, connection);
                reader = cmb.ExecuteReader();
                while (reader.Read())
                {
                    counts = reader.GetInt16("count(*)"); ;
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

        public  bool check_item_available_in_items(int stock_id)
        {
            try
            {
                bool results = false;
                String inser_query = "select * from item where stock_id="+stock_id+" and order_id is not null or availability=1;";
                connection.Open();
                cmb = new MySqlCommand(inser_query, connection);
                MySqlDataReader reader = cmb.ExecuteReader();
               while (reader.Read())
                {
                    results = true;
                    //Console.WriteLine(reader.GetString("item_id"));
                    //connection.Close();

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
