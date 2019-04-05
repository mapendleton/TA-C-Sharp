using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tasks = { "be multiplied by 50", "add 25 to it", "divide it by 12.5", "check if it's greater than 50", "find remainder divided by 7" };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number to " + tasks[i]);
                int input = Convert.ToInt32(Console.ReadLine());
                Console.Write("Answer: ");
                switch (i)
                {
                    case 0:
                        Console.WriteLine(input * 50);
                        break;
                    case 1:
                        Console.WriteLine(input + 25);
                        break;
                    case 2:
                        Console.WriteLine(input / 12.5);
                        break;
                    case 3:
                        bool trueOrFalse = input > 50;
                        Console.WriteLine(trueOrFalse.ToString());
                        break;
                    case 4:
                        Console.WriteLine(input % 7);
                        break;
                    default:
                        Console.WriteLine("error: something wrong with switch statement");
                        break;
                }
            }
            Console.Read();
           

            

        }
    }
}
