using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace iterations
{
    class Program
    {
        static void Main()
        {

            int num = 0;

            do
            {
                Console.WriteLine("select the step number of the assignment to see it. select a number from 1 - 11");
                Console.WriteLine("Enter number '0' to exit \n");
                num = int.Parse(Console.ReadLine());

                if (num <= 11 && num >= 1)
                {
                    switch (num)
                    {
                        case 1:
                            Step1();
                            break;
                        case int i when (i == 2 || i == 3):
                            Step2And3();
                            break;
                        case 4:
                            Step4();
                            break;
                        case 5:
                            Step5();
                            break;
                        case int i when (i == 6 || i == 7 || i == 8):
                            Step6And7And8();
                            break;
                        case int i when (i == 9 || i == 10 || i == 11):
                            Step9And10And11();
                            break;
                        default:
                            Console.WriteLine("something is wrong");
                            break;
                    }
                }
            } while (num != 0);
            
            

            Console.Read();
        }

        static void Step1()
        {
            //assignment step 1

            string[] strArray = { " bob", " lisa", " matt", " luke" };
            Console.WriteLine("input some text: ");
            string strInput = Console.ReadLine();
            for (int i = 0; i < strArray.Length; i++)
            {
                string newStr = strInput + strArray[i];
                Console.WriteLine(newStr);
            }
        }

        static void Step2And3()
        {
            //assignment step 2

            //while (true)
            //{
            //    Console.WriteLine("you can't stop meeeee");
            //}

            //assigment step 3

            int stop = 0;
            while (stop != 5)
            {
                Console.WriteLine("you can't stop meeeee");
                stop++;
            }
            Console.WriteLine("noo you stopped me");
        }

        static void Step4()
        {
            //assignment step 4

            int stepFour = 0;
            while (stepFour < 4)
            {
                Console.WriteLine("step fouuuurrrrr");
                stepFour++;
            }
        }

        static void Step5()
        {
            //assignment step 5

            int counter = 0;
            do
            {
                if (counter == 5)
                {
                    Console.WriteLine("GO");
                }
                else
                {
                    Console.WriteLine(counter);
                }

                counter++;
            } while (counter <= 5);
        }

        static void Step6And7And8()
        {
            //assignment step 6 & 7

            List<string> strList = new List<string> { "arden", "gina", "mary", "waldo", "frank", "brock", "butch", "helga" };
            Console.WriteLine("guess a name that's in the list!");
            string input = Console.ReadLine();
            bool exhists;
            do
            {
                //check if user input exhists in list
                if (strList.Contains(input))
                {
                    Console.WriteLine("{0} is at position {1} of the list!", input, strList.IndexOf(input));
                    exhists = true;
                }
                else
                {
                    //if user input doesn't exhist try again. Or type 'exit' to give up
                    Console.WriteLine("could not find {0} in the list, guess again",input);
                    Console.WriteLine("type \"exit\" to quit");
                    input = Console.ReadLine();
                    if (input == "exit")
                    {
                        return;
                    }
                    exhists = false;
                }
            } while (!exhists);
            
        }
        static void Step9And10And11()
        {
            List<string> fruits = new List<string> { "strawberry", "apple", "orange", "banana", "apple", "lime", "lemon", "cocont", "grape","orange" };
            Console.WriteLine("type in a fruit to search for");
            string input = Console.ReadLine().ToLower();
            bool exhists;
            do
            {
                if (fruits.Contains(input))
                {
                    exhists = true;
                    for (int i = 0; i < fruits.Count; i++)
                    {
                        if (input == fruits[i])
                        {
                            Console.WriteLine("{0} is in index {1} of the list", input, i);
                        }
                    }

                    Console.WriteLine("now checking for duplicates...");
                    Thread.Sleep(2000);

                    int id = 0;
                    foreach (string fruit in fruits)
                    {
                        //int id = fruits.IndexOf(fruit);
                        Console.WriteLine(id);
                        //too keep within bounds of list
                        int searchIndex = id == 0 ? 0 : id - 1;
                        //include second condition because otherwise first element in list would print that it appeared already which cannot be
                        if (fruits.LastIndexOf(fruit,searchIndex) == -1 || searchIndex == 0)
                        {
                            Console.WriteLine("{0} has not appeared yet in the list",fruit);
                        }
                        else
                        {
                            Console.WriteLine("{0} has already appeared in the list!",fruit);
                        }

                        id++;

                    }
                }
                else
                {
                    Console.WriteLine("could not find {0} in the list", input);
                    Console.WriteLine("type in a fruit to search for");
                    input = Console.ReadLine().ToLower();
                    exhists = false;
                }
            } while (!exhists);
            
        }

    }
}
