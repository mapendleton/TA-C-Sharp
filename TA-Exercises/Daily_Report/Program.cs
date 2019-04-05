using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "The Tech Academy"
                + Environment.NewLine
                + "Student Daily Report"
                );
            Console.WriteLine();
            //question and input
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            //could do int, not sure if TA wants that, but it doesn't look like
            //it'd be used for any math so a string should be fine right?
            //incase they type in 'five' or something
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            //did bool because of the TA exercise probably wanting me to demonstrate casting
            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExp = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.Read();

        }
    }
}
