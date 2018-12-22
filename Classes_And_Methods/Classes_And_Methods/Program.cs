using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type a number");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("your number squared: " + Methods.Squared(input));

            Console.WriteLine("your number cubed: " + Methods.Cubed(input));

            Console.WriteLine("your minimum tip: " + Methods.MinTipCalc((float)input));

            Console.Read();
        }
    }
}
