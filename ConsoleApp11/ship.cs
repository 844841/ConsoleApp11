using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class ship:Vehicle
    {
        public void ShowShip()
        {
            Console.WriteLine("from ship");
        }
        
        new public void ShowVehicle()
        {
            Console.WriteLine("Cruise liner ship");
        }
    }
}
