using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Train :RoadwayVehicle
    {
        public void showTrain()
        {
            Console.WriteLine("from train");
        }

        public override void Show()
        {
            //base.Show();
            Console.WriteLine("train track is perfect");
        }
    }
}
