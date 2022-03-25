using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class outvar
    {
        public string calc(int a,int b,out int add,out int mul,out float sub)
        {
            add = a + b;
            mul = a * b;
            sub = a - b;
            return " " + a + " " + b + "Addition " + add + "Substraction" + sub +
                "Multiplication" + mul;
        }
    }
}
