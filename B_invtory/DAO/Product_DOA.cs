using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_invtory.DAO
{
    class Product_DOA 
    {
        //encaculated
        private int product_id;     
        private String product_name;
        private int user_type;
        private int cat_id;
        private String image_path;
        private String about;
        private String size;
        private Double price;

        public Double Price
        {
            get { return price; }
            set { price = value; }
        }
        public String Size
        {
            get { return size; }
            set { size = value; }
        }

        public String About
        {
            get { return about; }
            set { about = value; }
        }

        public String Image_path
        {
            get { return image_path; }
            set { image_path = value; }
        }
        public int Cat_id
        {
            get { return cat_id; }
            set { cat_id = value; }
        }
        public int User_type
        {
            get { return user_type; }
            set { user_type = value; }
        }


        public String Product_name
        {
            get { return product_name; }
            set { product_name = value; }
        }
        public int Product_id
        {
            get { return product_id; }
            set { product_id = value; }
        }



    }
}
