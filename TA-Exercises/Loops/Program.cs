using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What's your favorite color? ");
            string favColor = Console.ReadLine();
            favColor.ToLower();
            bool correct = favColor == "green";
            //if green is first guess end program
            Console.WriteLine(favColor == "green" ? "first guess correct!? nice! no need to go on." : "missed the first guess");
            while(!correct)
            {
                Console.WriteLine("Wrong! Try again: ");
                favColor = Console.ReadLine();
                favColor.ToLower();
                if(favColor == "green")
                {
                    Console.WriteLine("Correct! So far so good what about your favorite number? ");
                    int favNum = int.Parse(Console.ReadLine());
                    do
                    {
                        if(favNum == 37)
                        {
                            Console.WriteLine("Wow so smart! Correct!");
                            correct = true;
                        }
                        else
                        {
                            Console.WriteLine("Wrong! Try again: ");
                            favNum = int.Parse(Console.ReadLine());
                            correct = false;
                        }
                    } while (!correct);

                }

            }
            Console.Read();
        }
    }
}
