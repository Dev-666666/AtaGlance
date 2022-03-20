using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class NameException:Exception
    {
        public  NameException(String m):base(m)
        {
            
        }

       public void mesg(string msg)
        {
            throw new Exception("Invalid Name");
        }
    }
}
