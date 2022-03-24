using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_TR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //student
            Student s = new Student();
            s.showInfo();
            Student s1 = new Student("Devashri Desai",79.15f);
            s1.showInfo();
            Student s2 = new Student("Gauri Desai", 82.1023f);
            s2.showInfo();
            //Product

        }
    }
}
