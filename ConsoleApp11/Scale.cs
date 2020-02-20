using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Scale
    {
        double inch;
        double centimeters;

        public double Inch
        {
            get { return centimeters * 2.54; }
            set
            {
                centimeters = value / 2.54;
            }
        }
              
        public void showCentimeters()
        {
            Console.WriteLine("{0} inch: {1} centimeter",inch,centimeters);
            
        }
    }

   
}
