using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Employee e1 = new Employee();
            //    Console.WriteLine(e1.GetValues());

            //    Employee e2 = new Employee(2, "Dhanu", 35000);
            //    Console.WriteLine(e2.GetValues());
            //}


            //Student s1 = new Student();
            //s1.Calculate();
            //Console.WriteLine(s1.GetValues());

            //Student s2 = new Student(4, "Dhanu", 70, 80, 85);
            //s2.Calculate();
            //Console.WriteLine(s2.GetValues());


            Course c1 = new Course();
            Console.WriteLine(c1.GetValues());

            Course c2 = new Course(102, "C#", 45000);
            Console.WriteLine(c2.GetValues());
        }
    }
}
