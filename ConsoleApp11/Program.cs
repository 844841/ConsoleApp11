using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
         static void Main(string[] args)
        {
            Employee emp = new Employee
            {
                EmpId = 101,
                Name = "Anand",
                Dept = new Department { DeptId = 1, DeptName = "production" }
            };

            Console.WriteLine("{0}\t{1}", emp.EmpId, emp.Name);
            Console.WriteLine("{0}\t{1}", emp.Dept.DeptId, emp.Dept.DeptName);

            



         /*  RoadwayVehicle rv = new RoadwayVehicle();
            rv.ShowVehicle();
            rv.Show();
            Train tr = new Train();
            tr.showTrain();
            tr.Show();
            tr.ShowVehicle();
            ship sp = new ship();
            sp.ShowShip();
            sp.ShowVehicle(); */




           // vehicleobj();



            //  Program prg = new Program();
            // prg.Nonstaticmethod();

            //MethodOverloadingDemo();
            //AutomaticPropertiesDemo();

        }

        private static void vehicleobj()
        {
            transport v = new transport { No = 1, Model = "Hondacity", Modeltype = "car", Price = 150000 };
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", v.No, v.Model, v.Modeltype, v.Price);
            transport v1 = new transport { No = 2, Model = "Duet", Modeltype = "scooty", Price = 80000 };
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", v1.No, v1.Model, v1.Modeltype, v1.Price);
        }


        /*  sales s1 = new sales();
           s1.Prdname = "cake";
           s1.Qntity = 3;
           s1.Price = 125;
           Console.WriteLine("{0}\t{1}", s1.Prdname, s1.Qntity);
           Console.WriteLine();
           Console.WriteLine();*/

        private static void staticdatamethod()
        {
            sample sp = new sample();
            sample s1 = new sample();
            sample s2 = new sample();
        }






        public void Nonstaticmethod()
        {
            Console.WriteLine("this is non-static method");
        }


        private static void MethodOverloadingDemo()
        {
            Calculate clt = new Calculate();
            Console.WriteLine(clt.area(12));
            Console.WriteLine(clt.area(10, 20));
            Console.WriteLine(clt.area(15.7));
            Console.WriteLine(clt.area(10.6, 9));
        }
    }


   
   /*

    private static void AutomaticPropertiesDemo()
    {
        Product pd = new Product { Id = 1, Pname = "Chocolate", Price = 100 };
        Console.WriteLine("{0}\n{1}\n{2}", pd.Id, pd.Pname, pd.Price);
    }

    //  TimeObjMethod();

    private static void TimeObjMethod()
    {
        TimePeriod tp = new TimePeriod();
        tp.Hours = 15;
        Console.WriteLine("hours:{0}", tp.Hours);
        tp.showSeconds();
    }



    */


    /* student std = new student();

     std.Name = "Aman";
     std.Idno = 123;
     std.Course = "C#";
     // std.JoinDate = DateTime.Parse("01-10-2020");
     std.Joindate = Convert.ToDateTime("20-01-2020");
     Console.WriteLine("name is {0} \n ID is{1}", std.Name, std.Idno);
     Console.WriteLine("course: {0} \n JoiningDate is{1}", std.Course, std.JoinDate);


     //calobj();
     //object of trainee class
     //  Trainee tr = new Trainee();

     //  tr.Getdata("Supraja", "w234", "andhra", 21);
     //  tr.ShowData();

     // getTrObj();

     /*  car mycar = new car();
       car mycar2 = new car("AP301234S");
      car mycar1 = new car("ap212345", "indigo", "white", 30000);
      Console.WriteLine( mycar.showcar());
      string data = mycar1.showcar();
      Console.WriteLine(data);
      mycar1.showcar();*/
    //   }

    /*private static void getTrObj()
    {
        Trainee tr1 = new Trainee();
        Console.WriteLine();
        tr1.Getdata("chotu", "w345", "chennai", 23);
        tr1.ShowData();
    }

    static void exmobj()
    {
        exam exm = new exam();
        exm.Getexam("sai", 21, "c#", 2, "GMR");
        exm.Showexam();


    }

    //public void showcar()

   // public string showcar()
   // {
     //   return string.Format("reg no:{0}")    */





    /*  private static void calobj()
      {
          calculator cal = new calculator();
          calculator cal1 = new calculator(1, 2);
          //obj.addition();
          int addition = cal1.add();
          int dif = cal1.difference();
          int pro = cal1.product();
          int div = cal1.divide();


          Console.WriteLine("addition is" + addition);
          Console.WriteLine("subtraction is" + dif);
          Console.WriteLine("product is" + pro);
          Console.WriteLine("division is" + div);
      }


  }*/




    //  }


}   