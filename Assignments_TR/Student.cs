using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_TR
{
    internal class Student
    {
        static int no=0;
        int roll_no;
        string name;
        float per;

        public Student()
        {
            no++;
            this.roll_no =no;
            this.name = "Please confirm the name";
            this.per = 10f;
        }
        public Student(string name,float per)
        {
            this.roll_no = no;
            this.name = name;
            this.per = per;
        }

        public  void showInfo()
        {
            Console.WriteLine("\n Roll_no: {0} \n Student Name {1} \n Student Percentage {2} ",roll_no ,name,per );
        }
    }
}
