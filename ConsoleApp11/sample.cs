using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class sample
    {
        int no = 0;
        static int cnt = 0;

        public sample()
        {
            no++;
            cnt++;
            Console.WriteLine("no:{0}\ncount:{1}",no,cnt);
        }
        public static void Show()
        {
            cnt++;
            Console.WriteLine("from static show method and count is {0}",cnt);
        }
    }
}
