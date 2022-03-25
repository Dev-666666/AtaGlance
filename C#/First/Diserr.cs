//5. WAP in C# using switch case for following:
//Area of a circle Area of a square Area of a right angled triangle
//Area of a rectangle Circumference of a circle
//Perimeter of a square Accept inputs like radius,side,etc through keyboard. //Menu driven program using switch case:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBasicsDemos
{
    internal class Diserr
    {
        static void Main(string[] args)
        {

            char c = 'y';
            while (c == 'y')
            {
                int ch;
                Console.WriteLine("Welcome to Alpha Operations:");
                Console.WriteLine("1.Area of a circle 2.Area of A square 3.Area of RT Angle Traingle 4.Area of Rectangle 5.Circustance of Circle 6.Perimeter of Square");
                Console.WriteLine("Enetr your choice");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the radius for circle");
                        int r = Convert.ToInt32(Console.ReadLine());
                        float area = 3.14f * r * r;
                        Console.WriteLine("Area of Circle is : " + area); break;
                    case 2:
                        Console.WriteLine("Enter side of square ");
                        int side = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Area of Square is : " + side * side);
                        break;
                    case 3:
                        Console.WriteLine("Enter the height and base of rt angle traingle");
                        int ht = Convert.ToInt32(Console.ReadLine());
                        int bs = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Area of RT angle Traingle is: " + (ht * bs) / 2); break;
                    case 4:
                        Console.WriteLine("Enter length and breadth");
                        int l = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Area of Rectangle is  : " + l * b);
                        break;
                    case 5:
                        Console.WriteLine("Enter the Radius of circle");
                        int rad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Circumstance of circle is: " + 2 * .314f * rad);
                        break;
                    case 6:
                        Console.WriteLine("Enter the side of square");
                        int sy = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Perimeter of Squsre is: " + 4 * sy);
                        break;
                    default:
                        Console.WriteLine("Enter the correct choice");
                        break;

                }
                Console.WriteLine("Do you want to continue? y/n");
                c = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
