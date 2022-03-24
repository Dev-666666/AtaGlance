//11.WAP a program to check whether entered number is 3 digit or not .If it is a 3 digit no. then do sum of 1st and 3rd digit and print sum.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBasicsDemos
{
    internal class cntnoadd
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            Console.WriteLine("Enter the Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int ori = number, sum = 0;
            int first = ori % 10;
            int last = ori / 100;
            while(number>0)
            {
                int r = number % 10;
                cnt = cnt + 1;
                number = number / 10;
            }
            if (cnt == 3)
            {
                sum = first + last;
                Console.WriteLine($"Sum={sum} {first}   {last}");
            }
            else Console.WriteLine("Not 3 Digiit No.");
        }
    }
}
