using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace approval
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? answer 'true' for yes, or 'false' for no");
            string duiInput = Console.ReadLine();

            //make sure user doesn't type anything else except 'true' or 'false'
            bool incorrectInput = true;
            while (incorrectInput)
            {
                if (duiInput == "true" || duiInput == "false")
                {
                    incorrectInput = false;
                }
                else
                {
                    Console.WriteLine("Please enter 'true' for yes, or 'false' for no");
                    duiInput = Console.ReadLine();
                    incorrectInput = true;
                }
            }
            
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = int.Parse(Console.ReadLine());

            //checks if user is qualified
            bool isQualified = (age > 15 && duiInput == "false" && tickets <= 3);

            if (isQualified)
            {
                Console.WriteLine("you are qualified!");
            }
            else
            {
                Console.WriteLine("Sorry, you are not qualified.");
            }

            Console.Read();
        }
    }
}
