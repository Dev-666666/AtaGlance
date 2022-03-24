using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public delegate Double forDeposdel();
    public delegate void forwithdrwdel();
    internal class Program
    {
        static void withzerobal()
        {
            Console.WriteLine("Your Balance is Nil");
        }
        static void withmin3ths()
        {
            Console.WriteLine(" Please keep min balance 3000");
        }
        static void withamtless()
        {
            Console.WriteLine( "Cant withdraw Insufficient Balance");
        }
        static void Main(string[] args)
        {
            
            Bank b = new Bank();
            b.zerobal += new forwithdrwdel(withzerobal);
            b.min3ths += new forwithdrwdel(withmin3ths);
            b.cntwithdr += new forwithdrwdel(withamtless);
            Console.WriteLine("Wlcome to :" +b.b_name+ "\nIFSC: "+b.ifsc);
        start:
            Console.WriteLine("a.Deposite  b.Withdrawal c.CheckBalance");
            Console.WriteLine("Enter the operation");
            char ch = Convert.ToChar(Console.ReadLine());
            switch(ch)
            {
                case 'a':
                    Console.WriteLine("Enter the amount to Deposite");
                    double amt1 = Convert.ToInt32(Console.ReadLine());
                    b.Dpose(amt1);break;

                case 'b':
                    Console.WriteLine("Enter the amount to withdreaw");
                    double wamt = Convert.ToInt32(Console.ReadLine());
                    b.withdrow(wamt);break;
                case 'c':
                    Console.WriteLine(" Your Account Balance is");
                   
                    b.show(); break;
                default: Console.WriteLine("Thank you Viist Again:");break;
            }
           
            goto start;

        }
    }
}
