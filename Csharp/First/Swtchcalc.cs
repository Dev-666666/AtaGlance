//1.Write a C# program to create Simple Calculator using switch case Menu Driven 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBasicsDemos
{
    internal class Swtchcalc
    {
        static void Main(string[] args)
        {
             char c = 'y';
            while (c == 'y')
            {
                int ch;
                Console.WriteLine("Welcome to Alpha Operations:");
                Console.WriteLine("1.Addition 2.Sustraction 3.Multiplication 4.Division");
                Console.WriteLine("Enetr your choice");
                ch = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the two numbers to Add");
                int number1 = Convert.ToInt32(Console.ReadLine());
                int number2 = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Addition is : "+(number1+number2)); break;
                    case 2:
                        Console.WriteLine("Substraction is : " + (number1 - number2)); break;
                    case 3:
                        Console.WriteLine("Multiplication is : " + (number1 * number2)); break;
                    case 4:
                        Console.WriteLine("Division is : " + (number1 / number2));
                        break;
                    default: Console.WriteLine("Enter the correct choice"); break;

                }
                Console.WriteLine("Do you want to continue? y/n");
                c = Convert.ToChar(Console.ReadLine());
            }  
        }
    }
}
