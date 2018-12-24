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
            //Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 1001};
            //Employee employee2 = new Employee() { FirstName = "Ray", LastName = "Cool", Id = 1003 };


            //p.131 53% C# course generics exercise
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "Book", "computer", "stuff", "things" };

            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int>() { 1, 2, 3, 4, 5 };

           
            Console.WriteLine("This employees things: ");
            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine("This employees things: ");
            foreach (int thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }


            Console.Read();

            //employee1.SayName();
            //employee1.Quit();

            //IQuittable employee2 = new Employee() {FirstName = "Bob", LastName ="Hob",Id = 1002};
            //employee2.Quit();
            //Console.Read();
        }
    
    }
}
