using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBasicsDemos
{
    internal class Mnyinswtch
    {
        static void Main(string[] args)
        {
            char c = 'y';
            while (c == 'y')
            {
                int ch;
                Console.WriteLine("Welcome to Alpha Operations:");
                Console.WriteLine("1.VowelConso 2.isDigit-isAlpha-isSymb 3.Even-Odd 4.Pos-Neg");
                Console.WriteLine("Enetr your choice");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the character to check vowel or conso"); 
                        char c1 = Convert.ToChar(Console.ReadLine());
                          if (c1.Equals('a') || c1.Equals('e') || c1.Equals('i') || c1.Equals('u'))
                           Console.WriteLine("Entered " + c1 + " is vowel");
                          else Console.WriteLine("Its consonant"); break;
                    case 2:
                        Console.WriteLine("Enter anything ");
                        char any = Convert.ToChar(Console.ReadLine());
                        if (char.IsDigit(any)) Console.WriteLine("Its a digit");
                        else if (char.IsLetter(any)) Console.WriteLine("Its a Letter");
                        else Console.WriteLine("Its a special Symbol");
                        break;
                    case 3: Console.WriteLine("Enter the number to check even odd");
                        int no = Convert.ToInt32(Console.ReadLine());
                        if (no % 2 == 0) Console.WriteLine($"{no}is Even");
                        else Console.WriteLine($"{no}is odd");break;
                    case 4: Console.WriteLine("Enter the number to check Positive Negative");
                        no = Convert.ToInt32(Console.ReadLine());
                        if (no > 0) Console.WriteLine($"{no} is Positive");
                        else Console.WriteLine($"{no} is Negative");
                        break;
                    default: Console.WriteLine("Enter the correct choice");break;

                }
                Console.WriteLine("Do you want to continue? y/n");
                c = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
