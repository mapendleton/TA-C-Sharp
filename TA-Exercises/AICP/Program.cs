using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            float[] salary = new float[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(Environment.NewLine + "Person " + (i + 1));
                Console.WriteLine("Hourly Rate?");
                float.TryParse(Console.ReadLine(), out float hourWage);

                Console.WriteLine("Hours Worked per week?");
                float.TryParse(Console.ReadLine(), out float hoursWorked);

                salary[i] = hourWage * hoursWorked * 52;
            }

            int j = 1;
            foreach (float item in salary)
            {
                Console.WriteLine("Annual salary of Person " + j + ": ");
                Console.WriteLine(item);
                j++;
            }

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = salary[0] > salary[1];
            Console.WriteLine(trueOrFalse);
            Console.ReadLine();

        }
    }
}
