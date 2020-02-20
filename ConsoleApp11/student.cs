using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class student
    {
        string firstname;
        string lastname;
        int idno;
        string course;
        DateTime joindate;

        public student() { }

        public student(string fn,string ln)
        {
         firstname=fn;
         lastname=ln;
        }


        public string Name       ///read only property
        {
            get { return string.Format("{0}{1}",firstname,lastname); }
        
        }

        public int Idno
        {
            get { return idno; }
            set { idno = value; }
        }

        public string Course
        {
            set { course = value; }
            get { return course; }

        }

        public DateTime Joindate
        {
            get { return joindate; }
            set { joindate = value; }
        }


    }
}
