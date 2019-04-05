using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            //assignment step 1
            string[] strArray = { "bob", "luke", "hope", "lisa", "nuna" };
            Console.WriteLine("pick a number between 0 and 4, that will be your new name");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("your new name is: " + strArray[input]);

            //assignment step 2 and 3
            int[] intArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("pick a number between 0 and 4, that's how many years you have left to live. muahaha.");
            int numInput = int.Parse(Console.ReadLine());
            bool isNotIndex = numInput > 4;
            do
            {
                if(numInput > 4)
                {
                    isNotIndex = true;
                    Console.WriteLine("a number between 0 and 4 please");
                    numInput = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("you have " + intArray[numInput] + " years left");
                    isNotIndex = false;
                }
            } while (isNotIndex);

            //assignment step 4
            List<string> strList = new List<string>();
            strList.AddRange(strArray);
            Console.WriteLine("select another num between 0 and 4, this is the name of the person who will kill you.");
            Console.WriteLine("look out for someone named " + strList[int.Parse(Console.ReadLine())]);

            Console.Read();
        }
    }
}
