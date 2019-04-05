using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Enter package weight: ");
            float packWeight = float.Parse(Console.ReadLine());

            //check weight
            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
            }
            else
            {
                Console.WriteLine("Enter package width: ");
                float packWidth = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter package height: ");
                float packHeight = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter package length: ");
                float packLength = float.Parse(Console.ReadLine());

                float packDimensions = packWidth + packHeight + packLength;

                if(packDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    //display quote up to 2 decimal places
                    float quote = packDimensions * packWeight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("#.##") + " Thank you.");
                }
            }
            Console.Read();
        }
    }
}
