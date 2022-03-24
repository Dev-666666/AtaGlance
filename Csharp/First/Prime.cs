using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBasicsDemos
{
    internal class Prime
    {
        static void Main(string[] args)
        {
            int number;int cnt=0;
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                  cnt= cnt + 1;
                }
            }
            if (cnt<2)
            { Console.WriteLine("Number is Prime"); }
            else { Console.WriteLine("Not prime"); }
        }

    }
}
