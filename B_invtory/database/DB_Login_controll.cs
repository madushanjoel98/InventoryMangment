using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using B_invtory;
namespace B_invtory.databse
{
    class Products_DB
    {
     static Sechema_Connection get_connection = Sechema_Connection.getIntance();
    private MySqlConnection connection = get_connection.connection();
   public  MySqlCommand cmb = null;
        public  bool insert_admin(String email,String emp_no,String password){
            try
            {//Sign up code
                bool results = false;
                String inser_query = "INSERT INTO admin (email, emp_no, password)"
                + "VALUES('" + email.ToLower() + "','" + emp_no + "','" + password + "');";
                connection.Open();
                cmb = new MySqlCommand(inser_query, connection);
                if (cmb.ExecuteNonQuery() == 1)
                {
                    connection.Close();
                    results = true;
                }

                return results;
            }
            catch(MySqlException e) {
                connection.Close();
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public bool admin_login(String email, String password)
        {
         try
           {
                bool results = false;
 String inser_query = "Select * from admin where email='" + email.ToLower() + "' and password='" + password + "';";
                connection.Open();
                cmb = new MySqlCommand(inser_query, connection);
                MySqlDataReader reader = cmb.ExecuteReader();
                if (reader.Read())
                {
                    results = true;
                   
                }
                connection.Close();
                return results;
          }
            catch (MySqlException e)
            {
                connection.Close();
                MessageBox.Show(e.ToString(), "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }
   
    
    
    
    }
}
