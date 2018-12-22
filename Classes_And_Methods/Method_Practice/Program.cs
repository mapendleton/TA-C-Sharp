using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            ExClass exClass = new ExClass();
            exClass.SomeMath(5, 5);
            exClass.SomeMath(num1: 3, num2: 4);

            Console.Read();
        }
    }
}
