using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abstraction
            circle c = new circle(); c.area();
            Rectangle r = new Rectangle(); r.area();
            Square s = new Square(); s.area();
            //Exception
         /*   Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            try {
                if (name.Equals(null))
                {
                    throw new NameException("Invalid");
                    
                }
                else { Console.WriteLine("Welcome :" + name); }
            }
            catch(NameException e)
            {
                Console.WriteLine(" "+ e.Message);
            }*/
            //out variable use
            outvar v = new outvar();
            string reasult = v.calc(10, 20,out int a,out int b,out float cf);
            Console.WriteLine(" " + reasult) ;
         }
    }
}
