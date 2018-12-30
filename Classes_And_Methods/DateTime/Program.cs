using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("enter number");
            double hours = double.Parse(Console.ReadLine());
            DateTime dateTime = DateTime.Now.AddHours(hours);
            Console.WriteLine(dateTime);
            Console.Read();
        }
    }
}
