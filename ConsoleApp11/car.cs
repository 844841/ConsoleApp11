using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class car
    {
        string regno;
        string model;
        string color;
        double price;

        public car() { }//default constructor

        public car(string reg)  //overloaded
        {
            regno = reg;
        }

        public car(string reg, string mod)
        {
            regno = reg;
            model = mod;
        }

        public car(string reg,string mod,string colr,double pr)
        {
            regno = reg;
            model = mod;
            color = colr;
            price = pr;
        }

        public void showcar()
        {
            Console.WriteLine("reg no is " + regno);
            Console.WriteLine("model is {0}" + model);
            Console.WriteLine("color is " + color);
            Console.WriteLine("price is " + price);

            string.Format("reg no");

        }
                   

    }
    
}
