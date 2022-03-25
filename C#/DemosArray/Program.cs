using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int[,] list = new int[3, 5] { { 01, 02, 03, 04, 05 }, { 12, 44, 2, 54, 33 }, { 90, 29, 33, 22, 1 } };

             for (int i = 0; i < list.GetLength(0); i++)
             {
                 for (int j = 0; j < list.GetLength(1); j++)
                 {
                     Console.Write(" " + "{" + list[i, j] + "}");
                 }
                 Console.WriteLine(" ");
             }

             //arrdemo
             Class1 c = new Class1();
             c.run();

            //ArrayList
            Colection.Arraylist a = new Colection.Arraylist();
             a.runAL();

            //DemoStack and Queue
            Colection.DemostckQ d = new Colection.DemostckQ();
            Console.WriteLine("......StackDemo.....\n");
            d.rundtack();
            Console.WriteLine("......QueueDemo.....\n");
            d.runQ();

            //Gedemo 
            Generic.GenDmo gd = new Generic.GenDmo();
            gd.runlist();
            Console.WriteLine(".........GenStack.........");
            gd.runstck();
            Console.WriteLine("....GenDictionary....");
            gd.runDict();
            Console.WriteLine("....GenDictionary....");
            gd.runQ();

        }
    }
}
