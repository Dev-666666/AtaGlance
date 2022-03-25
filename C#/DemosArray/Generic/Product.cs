using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Generic
{
    internal class Product
    {
        private string p_name;
        private int p_code;
        private int p_quantity;

        public Product(int cod,string name,int quan)
        {
            this.p_name = name;
            this.p_code = cod;
            this.p_quantity = quan;
        }

        public override string ToString()
        {
            return "Name " + p_name + "\t Code " + p_code + "\t Quantity " + p_quantity;
        }
    }
}
