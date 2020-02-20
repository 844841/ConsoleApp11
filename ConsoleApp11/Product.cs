using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Product
    {
        //automatic properties
        public int Id { get; set; }
        public string Pname { get; set; }
        public object Price { get; internal set; }
    }
}
