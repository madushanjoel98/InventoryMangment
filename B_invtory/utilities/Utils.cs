using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_invtory.utilities
{
    class Utils
    {
        
       static int random_numbers(){
        Random ran = new Random();
        return ran.Next(1000);
    
    }
        public static string file_name_create(string file_name) {
            string create = random_numbers().ToString() +
                DateTime.Now.Date.ToShortDateString().Replace("-", "").Replace("/", "") +
                file_name.ToLower().Replace(" ", "");
                

            return create;
        }

    }
}
