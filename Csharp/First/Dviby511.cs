using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBasicsDemos
{
    internal class Dviby511
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if(number%5==0 && number%11==0)
            {
                Console.WriteLine(number + " No.is Divisible bye 5 and 11");
            }
        }
    }
}
