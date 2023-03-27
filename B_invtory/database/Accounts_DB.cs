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
using MySql.Data.MySqlClient;
using System.IO;
using B_invtory.databse;

namespace B_invtory.database
{
    class Accounts_DB
    {
          static Sechema_Connection get_connection = Sechema_Connection.getIntance();
        private MySqlConnection connection = get_connection.connection();
        public MySqlCommand cmb = null;



        public int order_count(int month,int year)
        {
            try
            {
                int counts = 0;
                MySqlDataReader reader = null;
                String inser_query = "select count(*) as c from orders where month(order_recive_date)="+month+" and year(order_recive_date)="+year+";";
                connection.Open();
                cmb = new MySqlCommand(inser_query, connection);
                reader = cmb.ExecuteReader();
                if  (reader.Read())
                {
                    counts = reader.GetInt16("c") ;
                }
                connection.Close();
                return counts;
                
            }
            catch (Exception e)
            {
                connection.Close();
                //MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public double monthly_income(int month, int year)
        {
            try
            {
                double counts = 0;
                MySqlDataReader reader = null;
                String inser_query = "select sum(total) as sum from orders "+
                  "where month(delived_date)=" + month + " and year(delived_date)=" + year + ";";
                connection.Open();
                cmb = new MySqlCommand(inser_query, connection);
                reader = cmb.ExecuteReader();
                if (reader.Read())
                {
                    counts = reader.GetDouble("sum");
                }
                connection.Close();
                return counts;

            }
            catch (Exception e)
            {
                connection.Close();
                //MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int sold_item(int month, int year)
        {
            try
            {
                int counts = 0;
                MySqlDataReader reader = null;
                String inser_query = "select sum(qunity) as sum from orders where month(delived_date)="+month+" and year(delived_date)="+year+";";
                connection.Open();
                cmb = new MySqlCommand(inser_query, connection);
                reader = cmb.ExecuteReader();
                if (reader.Read())
                {
                    counts = reader.GetInt16("sum");
                }
                connection.Close();
                return counts;

            }
            catch (Exception e)
            {
                connection.Close();
                //MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public double yearly_income(int month, int year)
        {
            try
            {
                double counts = 0;
                MySqlDataReader reader = null;
                String inser_query = "select sum(total) as sum from orders"+
                    " where year(delived_date)=" + year + ";";
                connection.Open();
                cmb = new MySqlCommand(inser_query, connection);
                reader = cmb.ExecuteReader();
                if (reader.Read())
                {
                    counts = reader.GetDouble("sum");
                }
                connection.Close();
                return counts;

            }
            catch (Exception e)
            {
                connection.Close();
                //MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    
    }
}
