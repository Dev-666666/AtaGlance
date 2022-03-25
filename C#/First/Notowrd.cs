//4.Write a C# program to enter number between 1to 5 and print it in word
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBasicsDemos
{
    internal class Notowrd
    {
        static void Main(string[] args)
        {
            char c = 'y';
            while (c == 'y')
            {
                int ch;
                Console.WriteLine("Enter the Number ");

                ch = Convert.ToInt32(Console.ReadLine());


                switch (ch)
                {
                    case 1:
                        Console.WriteLine("One"); break;
                    case 2:
                        Console.WriteLine("Two"); break;
                    case 3:
                        Console.WriteLine("Three"); break;
                    case 4:
                        Console.WriteLine("Four"); break;
                    case 5:
                        Console.WriteLine("Five"); break;
                    case 6:
                        Console.WriteLine("Six"); break;
                    case 7:
                        Console.WriteLine("Seven"); break;


                    default: Console.WriteLine("Enter the correct choice"); break;

                }
                Console.WriteLine("Do you want to continue? y/n");
                c = Convert.ToChar(Console.ReadLine());
            }  }
    }
}
