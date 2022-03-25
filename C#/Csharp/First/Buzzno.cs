using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBasicsDemos
{
    internal class Buzzno
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if((number %7==0) && (number%10==7))
                Console.WriteLine($"{number}Buzz number");
            else
                Console.WriteLine("NOt");
           // Console.WriteLine((number%7==0)||(number%10==7)?"true":"false");
           
        }
    }
}
