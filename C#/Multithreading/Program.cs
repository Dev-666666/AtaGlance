using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            threaddemo td = new threaddemo();
            Thread t = new Thread(new ThreadStart(td.test2));
            Thread t1 = new Thread(new ThreadStart(td.test));
            Thread t2 = new Thread(new ThreadStart(td.test3));
            t.Priority = ThreadPriority.Lowest;
            t1.Priority = ThreadPriority.BelowNormal;
            t2.Start();
            t.Start();
            t1.Start();

        }
    }
}
