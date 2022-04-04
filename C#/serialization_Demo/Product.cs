using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialization_Demo
{
    [Serializable]
    public class Product
    {
        public int id { set; get; }
        public string name { set; get; }
        public string location { set; get; }
    }
}
