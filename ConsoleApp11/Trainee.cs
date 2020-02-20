using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Trainee
    {
        //data fields
        string name, id, address;   //instance variables
        int age;

        public void Getdata(string nm,string id,string adr,int ag)
        {
            name = nm;
            this.id = id;
            address = adr;
            age = ag;
        }

        public void ShowData()
        {
            Console.WriteLine(name);
            Console.WriteLine(id + " " + address + " " + age);
        }
    }
}
