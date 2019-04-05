using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                Console.WriteLine("enter a number to divide by");
                int userInput = int.Parse(Console.ReadLine());

                foreach (int num in numbers)
                {
                    Console.WriteLine(num / userInput);
                }
                Console.Read();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("made it through the try/catch block");
                Console.ReadLine();
            }
        }
    }
}
