using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            MathStuff mathStuff = new MathStuff();
            Console.WriteLine(mathStuff.DivideByFour(5));
            Console.WriteLine(mathStuff.DivideByFour(5m));
            Console.WriteLine(mathStuff.DivideByFour("5"));
            Console.Read();
        }
    }
}
