using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    abstract public class abstractDemo
    {
        abstract public void area();
      
    }

    public class circle:abstractDemo
    {
        public override void area()
        {
            Console.WriteLine("InCircle");
            Console.WriteLine("Circle with radious 20 :"+(3.14*20*20));

        }
    }

    public class Rectangle:abstractDemo
    {
        public override  void area()
        {
            Console.WriteLine("InRectangle");
            Console.WriteLine("Circle with length 20 breadth 10:" + (20 * 10));
        }
    }
    public class Square:abstractDemo
    {
        public override void area()
        {
            Console.WriteLine("InSquare");
            Console.WriteLine("Circle with side 20 :" + (20 * 20));
        }
    }
}
