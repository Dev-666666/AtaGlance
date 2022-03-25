using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_TR
{
    internal class Product
    {
        public int pcode;
        public string pname;
        public float pprice;

        public Product(int code,string name,float per)
        {
            this.pcode=code;
            this.pname=name;
            this.pprice=per;
        }
        public void display()
        {
            Console.WriteLine("Details are:Code-{0} Name-{1} Percentage-{2}",pcode,pname,pprice);;
            if(pprice > 5000)
            {
                pprice=(pprice*10)/100;
            }
            Console.WriteLine("Discount Applied:"+pprice);
        }
    }
}
