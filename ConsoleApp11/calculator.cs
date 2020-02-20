using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class calculator
    {
        int a, b;
        int c;

        public calculator() { }  //default

        public calculator( int a,int b)
        {
            this.a = a;
            this.b = b;
        }

        public int add()
        {
            c = a + b;
            return c;
        }

        public int difference()
        {
            c = a - b;
            return c;

        }

        public int product()
        {
            c = a * b;
            return c;
        }

        public int divide()
        {
            c = a / b;
            return c;
        }



    }
}
