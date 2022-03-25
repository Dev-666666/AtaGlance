using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Class1
    {
       public void run()
        {
            int[,] arrr= new int[4, 3];

            Console.WriteLine("Enter the Elements in Array");
            for(int i=0;i<arrr.GetLength(0);i++)
            {
                for(int j=0;j<arrr.GetLength(1);j++)
                {
                    arrr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < arrr.GetLength(0); i++)
            {
                for (int j = 0; j < arrr.GetLength(1); j++)
                {
                    Console.Write(" " + arrr[i, j]); 
                }
                Console.WriteLine(" ");
            }
        }


    }
}
