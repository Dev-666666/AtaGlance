using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array.Colection
{
    internal class DemostckQ
    {
        public static int c = 1;
        public void rundtack()
        {
            Stack s = new Stack();
            s.Push(10);
            s.Push("Good");
            s.Push(1000);
            Console.WriteLine("Added");
            foreach (Object i in s)
            {
                Console.WriteLine("Element " + i);
            }
            s.Pop();
            s.Pop();
            Console.WriteLine("After Pop Ops");
            foreach (Object i in s)
            {
                Console.WriteLine("Element " + i);
            }
            Console.WriteLine("Enter how many elementes want to push in stack");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<n;i++)
            {
               s.Push(Console.ReadLine());
            }

            foreach(Object i in s)
            {
                Console.WriteLine("Element "+ i);
            }
            s.Pop();
            s.Push("Delet mi");
            foreach(Object i in s)
            {
                Console.WriteLine("Element "+ i);
            }
            s.Pop();

            
        }

        public void runQ()
        {
            c = 0;
            Queue q = new Queue();
            q.Enqueue(781);
            q.Enqueue("harry");
            foreach (Object i in q)
            {
                Console.WriteLine("Element {0}  is {1} " , ++c,i);
            }
            Console.WriteLine("Enter how many elementes want to push in stack");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                q.Enqueue(Console.ReadLine());
            }
            foreach (Object i in q)
            {
                Console.WriteLine("Element " + i);
            }
            q.Dequeue();
            q.Dequeue();
            Console.WriteLine("Dqueued");
            foreach (Object i in q)
            {
                Console.WriteLine("Element " + i);
            }

           /* public void runhash()
            {

            }*/
        }
    }
}
