using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter current day of the week: ");
                string input = Console.ReadLine().ToLower();
                //Type enumType = typeof(DaysOfTheWeek);
                DaysOfTheWeek today = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input);
                Console.WriteLine("enum = " + today);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }

        }

        public enum DaysOfTheWeek
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday
        }
    }
}
