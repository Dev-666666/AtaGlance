using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Generic
{
    internal class Genmain<T>
    {
        private T data;
        public Genmain(T data)
        {
            this.data = data;
        }

        public void getData()
        {
            Console.WriteLine(" "+data);
        }
    }
}
