using System;
using MySql.Data.MySqlClient;

namespace B_invtory.databse
{
    class Sechema_Connection
    {
        private static Sechema_Connection intance = null;
        MySqlConnection connect = null;
        //sever root@localhost:3306
      private  String server = "localhost";
      private String port = "3306";
      private String database = "bhuvani";
      private String uid = "root";
      private String password = "1234";
      private Sechema_Connection() { }


      public static Sechema_Connection getIntance() {
          if (intance == null) {
              intance = new Sechema_Connection();
          }
          return intance;
      }
        
        public  MySqlConnection connection() {
            try
            {
                String connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                connect = new MySqlConnection(connectionString);
                return connect;
            }
            catch (MySqlException e) {
                connect.Close();


                return connect;
            
            }
        
        }






    }
}
