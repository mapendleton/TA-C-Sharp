using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            string input = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"C:/users/Matthew Pendleton/documents/Tech Academy Files/ExerciseLogs/log.txt",true))
            {
                file.WriteLine(input);
            }

            string result = File.ReadAllText(@"C:/users/Matthew Pendleton/documents/Tech Academy Files/ExerciseLogs/log.txt");
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
