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
    class other_DB_tables

    {
        static Sechema_Connection get_connection = Sechema_Connection.getIntance();
        private MySqlConnection connection = get_connection.connection();
        public MySqlCommand cmb = null;

        public MySqlDataReader select_All_catagory()
        {
            MySqlDataReader reader = null;
            try
            {
               
                String inser_query = "Select * from catagory";
                connection.Open();
                cmb = new MySqlCommand(inser_query, connection);
                 reader = cmb.ExecuteReader();
                 connection.Close();
                return reader;
            }
            catch (MySqlException e)
            {
                connection.Close();
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return reader;
            }
        }
        public MySqlDataReader select_All_usersGender()
        {
            MySqlDataReader reader = null;
            try
            {
               
                String inser_query = "Select * from users_gender";
                connection.Open();
                cmb = new MySqlCommand(inser_query, connection);
                reader = cmb.ExecuteReader();
             
                return reader;
            }
            catch (MySqlException e)
            {
                connection.Close();
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return reader;
            }
        }
        public BindingSource select_All_usersGenders_datasource() {
            BindingSource source = null;
            Dictionary<int, string> users = new Dictionary<int, string>();
            MySqlDataReader reader = null;
            try
            {
              
                String inser_query = "Select * from users_gender";
                connection.Open();
                cmb = new MySqlCommand(inser_query, connection);
                reader = cmb.ExecuteReader();
                while (reader.Read()) {
                    users.Add(reader.GetInt16("gender_id"), reader.GetString("gender_name"));
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

        public BindingSource select_All_catagory_by_gender_datasource(int user_gender_id)
        {
            BindingSource source = null;
            Dictionary<int, string> users = new Dictionary<int, string>();
            MySqlDataReader reader = null;
            try
            {
                bool results = false;
                String inser_query = "Select * from catagory where users_id='"+user_gender_id+"'";
                connection.Open();
                cmb = new MySqlCommand(inser_query, connection);
                reader = cmb.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(reader.GetInt16("id_catagory"), reader.GetString("catagory_name"));
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

        public String cat_name_by_id(int id_)
        {
            String counts = "";
            MySqlDataReader reader = null;
            try
            {

                String inser_query = "SELECT catagory_name FROM bhuvani.catagory where id_catagory="+id_+";";
                connection.Open();
                cmb = new MySqlCommand(inser_query, connection);
                reader = cmb.ExecuteReader();
                while (reader.Read())
                {
                    counts = reader.GetString("catagory_name"); ;
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

        public DataTable data_table(String query)
        {//Data table
            try
            {
                DataTable td = new DataTable();
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(td);
                connection.Close();

                return td;
            }
            catch (MySqlException e) {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            
            }


        }
        public int get_counts(String query,String output_pra)
        {
            int counts = 0;
            MySqlDataReader reader = null;
            try
            {
                connection.Open();
                cmb = new MySqlCommand(query, connection);
                reader = cmb.ExecuteReader();
                while (reader.Read())
                {
                    counts = reader.GetInt16(output_pra); ;
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
    
    
    }
}
