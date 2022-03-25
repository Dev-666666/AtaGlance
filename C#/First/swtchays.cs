/*2.Write a program that 
    displays the day of the week corresponding to the number entered- 
    1 - "Monday", 2- "Tuesday" and so on.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBasicsDemos
{
    internal class swtchays
    {
        static void Main(string[] args)
        {
            char c = 'y';
            while (c == 'y')
            {
                int ch;
                Console.WriteLine("Enter the Number which day you want");
            
                ch = Convert.ToInt32(Console.ReadLine());
                
               
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Welcome its Sunday"); break;
                    case 2:
                        Console.WriteLine("Welcome its Monday"); break;
                    case 3:
                        Console.WriteLine("Welcome its Tuesday"); break;
                    case 5:
                        Console.WriteLine("Welcome its Thursay");break;
                    case 6:
                        Console.WriteLine("Welcome its Friday"); break;
                    case 7:
                        Console.WriteLine("Welcome its Saturday"); break;
                    case 4:
                        Console.WriteLine("Welcome its Wedensday"); break;
                   
         
                    default: Console.WriteLine("error, day does not exist"); break;

                }
                Console.WriteLine("Do you want to continue? y/n");
                c = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
