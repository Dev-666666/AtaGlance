using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBasicsDemos
{
    internal class Leapyr
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            if(((year%4==0 )&& (year%100!=0)) || (year%400==0))
            {
                Console.WriteLine("Yes is leap year"+year);
            }
            else Console.WriteLine(" No is not leap year"+year);
        }
    }
}
