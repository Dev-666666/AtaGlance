using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Array.Colection
{
    internal class Arraylist
    {
       public void runAL()
        {
            ArrayList a = new ArrayList();
            //stach 
            Stack s = new Stack();
            s.Push("to the");
            s.Push("Training");
            s.Push("Session"); Console.WriteLine("..........Stack...............");
            foreach (Object i in s)
            {
                Console.WriteLine(i);
            }
            //array insertion
            a.Add(10);
            a.Add("Welcome");
            a.Add(20.9);
            a.Add(20.99f);
            //print arrray
            Console.WriteLine(".........................");
            foreach (Object i in a)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(".........................");
            //arrayInsert ops
            a.Insert(1, "You are");
            a.InsertRange(3, s);
            foreach(Object i in a)
            {
                Console.WriteLine(" "+i);
            }
            Console.WriteLine(".........................");
            a.RemoveAt(1);
            a.Remove(s);
            Console.WriteLine("Enter how many elementes want to insert in Array");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a.Add(Console.ReadLine());
            }
            foreach (Object i in a)
            {
                Console.WriteLine( " "+i);
            }
        }

    }
}
