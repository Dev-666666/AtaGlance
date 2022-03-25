using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Generic
{
    internal class GenDmo
    {
        public void runlist()
        {
            List<Product> prolist = new List<Product>();
            Product p1 = new Product(1,"Pencil",2);
            Product p2 = new Product(2, "Pen",42);
            Product p3 = new Product(3, "cil", 22);
            Product p4 = new Product(4, "encil", 10);
            prolist.Add(p1);
            prolist.Add(p2);
            prolist.Add(p3);
            prolist.Add(p4);

            foreach(Product p in prolist)
            {
                Console.WriteLine(" "+p);
            }

        }

        public void runstck()
        {
            Stack<int> sint = new Stack<int>();
            Stack<string> sstr = new Stack<string>();
            sstr.Push("Swamini");
            sstr.Push("Padmini");

            sint.Push(100);
            sint.Push(200);
            sint.Push(300);

            foreach(int i in sint)
            {
                foreach(string s in sstr)
                Console.WriteLine("Name :" +s +"int..."+i);
            }
            sint.Pop();
            sstr.Pop();
            foreach (int i in sint)
            {
                foreach (string s in sstr)
                    Console.WriteLine("Name :" + s + "int..." + i);
            }
        }

        public void runQ()
        {
            Queue<int> qint = new Queue<int>();
            Queue<string> qstr = new Queue<string>();
            qstr.Enqueue("Swamini");
            qstr.Enqueue("Padmini");

            qint.Enqueue(100);
            qint.Enqueue(200);
            qint.Enqueue(300);

            foreach (int i in qint)
            {
                foreach (string s in qstr)
                    Console.WriteLine("Name :" + s + "int..." + i);
            }

            qstr.Dequeue();
            qint.Dequeue();
            foreach (int i in qint)
            {
                foreach (string s in qstr)
                    Console.WriteLine("Name :" + s + "int..." + i);
            }
        }

        public void runDict()
        {
            int adhar, pan;
            Dictionary<int,int> dint = new Dictionary<int,int>();
            //Dictionary<float,string> dstr = new Dictionary<string>();

            Console.WriteLine("Enter the 3 key and values:");
            for (int i = 0; i < 3; i++)
            {
                adhar = Convert.ToInt32(Console.ReadLine());
                pan = Convert.ToInt32(Console.ReadLine());
                dint.Add(adhar, pan);
            }

            foreach(KeyValuePair<int,int> i in dint)
            {
               
                    Console.WriteLine("Key:valu:"+ i);
            }

           
        }
    }
}
