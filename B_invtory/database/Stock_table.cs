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
using B_invtory.databse;

namespace B_invtory.database
{
    class Stock_table
    {
         public int last_id { get; set; }
        static Sechema_Connection get_connection = Sechema_Connection.getIntance();
        private MySqlConnection connection = get_connection.connection();
        public MySqlCommand cmb = null;

       public Item_db_table_events itm = new Item_db_table_events();
        public bool bulk_insert_catcher = false;

        public bool insert(Stock_DOA stock)
        { try
            {
                int ava=0;
                bool results = false;
                String inser_query = "INSERT INTO stocks(qunity, recived_date, product_id)"
               + "VALUES('" + stock.qunity + "','" + stock.recived_date + "','" + stock.product_id + "');";

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
                    + "\n " + e.ToString(), "Error product insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
//throw new NotImplementedException();


        public bool update(Stock_DOA sdo)
        {
            bool validation = itm.check_item_available_in_items(sdo.stock_id);
            int counts = itm.count_of_available_item_by_stock_id(sdo.stock_id);
            int changes = sdo.qunity - counts;
           
                if (counts < sdo.qunity)
                {
                    changes = sdo.qunity - counts;
                    MessageBox.Show(" qunity grater than count: changer:" + changes.ToString());

                }
                else
                {
                    changes = counts - sdo.qunity;

                    MessageBox.Show("qunity than count changer:" + changes.ToString());

                }
           
            return true;

        }

        public void delete(int sid)
        {
         
            bool validation = itm.check_item_available_in_items(sid);
            if (validation == true)
            {
                MessageBox.Show("You can't delete this data");
            }
        }
    }
    
}
