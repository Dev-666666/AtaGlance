using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBasicsDemos
{
    internal class Maxbtw3
    {
        static void Main(string[] args)
        {
            int number1,number2, number3;
            Console.WriteLine("Enter three numbers");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            number3 = Convert.ToInt32(Console.ReadLine());
            if(number1>number2 && number1>number3)
                Console.WriteLine(number1+"is Greater");
            else if(number2 > number1 && number2>number3)
                Console.WriteLine(number2+"is Greater");
            else Console.WriteLine(number3+"is Greater");
        }

    }
}
