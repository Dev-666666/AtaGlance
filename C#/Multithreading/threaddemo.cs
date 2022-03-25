using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class threaddemo
    {
        public void test()
        {
            lock (this)
                {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("good");
                } }
        }
        public void test2()
        {
            lock(this)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("yeahhh");
                } }
        }
        public void test3()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ohhh");
            }
        }
    }
}
