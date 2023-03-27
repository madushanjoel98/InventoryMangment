using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_invtory
{
    class combobox_valuer
    {
       public String text{get;set;}
       public int value { get; set; }

        public override string ToString()
        {
            return text;
        }
    }
}
