using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace output_parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            //step 2
            OutputClass outputClass = new OutputClass();

            //step 3
            Console.WriteLine("enter number");
            int input = int.Parse(Console.ReadLine());
            outputClass.DivideByTwo(input, out int result);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
