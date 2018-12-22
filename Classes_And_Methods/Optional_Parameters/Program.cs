using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            Console.WriteLine("enter num 1");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter optional num 2");
            string input2 = Console.ReadLine();

            if (input2 == "")
            {
                Console.WriteLine(class2.DoSomeMath(input1));
            }
            else if (input2 != "")
            {
                int intNum = int.Parse(input2);
                Console.WriteLine(class2.DoSomeMath(input1, intNum));
            }

            Console.Read();
        }
    }
}
