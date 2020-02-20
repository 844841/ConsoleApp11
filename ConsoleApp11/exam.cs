using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class exam
    {
        string name, subject, college;
        public int hallno;
        int time;

        public void Getexam(string nm,int hno,string sub,int tym,string clg)
        {
            name = nm;
            subject = sub;
            college = clg;
            hallno = hno;
            time = tym;
        }

        public void Showexam()
        {
            Console.WriteLine(name);
            Console.WriteLine(hallno + " " + subject + " " + time + " " + college);
        }
    }
}
