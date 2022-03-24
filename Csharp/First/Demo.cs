using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBasicsDemos
{
    internal class Demo
    {
        static void Main(string[] st)
        {
            int a = 10;
            short b = 23456;
            long phno = 16273464556;
            Console.WriteLine("Int value" + a + "short value" + b + "phono" + phno);
            float f = 34.78909f;
            double d = 2.9029193;
            Console.WriteLine($"Floatvalue{f}Doublevalue{d}");
            Console.WriteLine("welcome \t Enter the name ");
            //string name = " ";
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name);

        }

    }
}
