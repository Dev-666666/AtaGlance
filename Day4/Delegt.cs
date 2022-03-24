using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Delegt
    {
        public delegate void Delcalc(int a);
        public delegate void Delmsg(string m);

        public void calc(int a)
        {
            Console.WriteLine("Addition is: " + (a + a));
        }
        public void msg(string m)
            {
            Console.WriteLine(" msg:"+m);
            }
    }
}
