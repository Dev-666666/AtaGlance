using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class NameException:Exception
    {
        public NameException(String m):base(m)
        {
            throw new Exception("Invalid Name");
        }

       public static void mesg(string msg)
        {
            throw new Exception("Invalid Name");
        }
    }
}
