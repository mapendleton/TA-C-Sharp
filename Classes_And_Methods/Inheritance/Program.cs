using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 1001};
            Employee employee2 = new Employee() { FirstName = "Ray", LastName = "Cool", Id = 1003 };

            Console.WriteLine(employee1 == employee2);

            Console.Read();

            //employee1.SayName();
            //employee1.Quit();

            //IQuittable employee2 = new Employee() {FirstName = "Bob", LastName ="Hob",Id = 1002};
            //employee2.Quit();
            //Console.Read();
        }
    }
}
