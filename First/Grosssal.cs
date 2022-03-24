/*10.Write a C# program to input basic salary of an employee and calculate its 
Gross salary according to following:
 Basic Salary <= 10000 : HRA = 20 %, DA = 80 %
 Basic Salary <= 20000 : HRA = 25 %, DA = 90 %
  Basic Salary > 20000 : HRA = 30 %, DA = 95 %*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBasicsDemos
{
    internal class Grosssal
    {
        static void Main(string[] args)
        {
            long gross,hra,da;
            Console.WriteLine("Enter the Basic salary");
            long salary = Convert.ToInt64(Console.ReadLine());
            hra = salary / 100 * 20;
            da = salary / 100 * 80;
            gross = salary + hra + da;
            Console.WriteLine($"Basic slary is {salary }  and Gross Salari is {gross}");
        }
    }
}
