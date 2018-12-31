using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your age");
                int age = int.Parse(Console.ReadLine());
                if (age <= 0)
                {
                    throw new ZeroOrBelowException("enter an age above 0");
                }

                int currentYear = DateTime.Now.Year;
                int yearBorn = currentYear - age;
                Console.WriteLine("Year born: {0}",yearBorn);
                Console.Read();
            }
            catch (ZeroOrBelowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Something else went wrong");
                Console.Read();
                return;
            }
            
        }
    }
}
