using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class sales
    {
        string productname;
        int quantity;
        double price;
        static double totalSalesAmount = 0;



        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Saleamount
        {
           get { return price * quantity; }
        }


        public double TotalAmount
        {
        get { return totalSalesAmount += Saleamount;}
        }

    }
}
