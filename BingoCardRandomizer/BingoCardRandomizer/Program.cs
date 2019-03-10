using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoCardRandomizer
{
    class Program
    {
        // random object to create random numbers
        public static Random rand = new Random();

        // Method that takes string input from a user and randomly places those on a 5x5 bingo card
        // with the middle slot already filled with "free"
        public static string[,] RandomizeBingoCard(string[] values)
        {
            string[,] bingoCard = new string[5, 5];
            bingoCard[2, 2] = "free";

            bool filled = true;
            // for when the bingo card is full so the do while loop doesn't run forever
            int maxCheck = 0;
            
            // for each value that is entered, a random slot on the bingo board is selected
            // if it is empty then the value is placed in that slot
            // if it is not empty, another value will be selected until an empty slot is found
            for (int i = 0; i < values.Length; i++)
            {
                do
                {
                    int rand1 = rand.Next(0, 5);
                    int rand2 = rand.Next(0, 5);

                    if (String.IsNullOrEmpty(bingoCard[rand1, rand2]))
                    {
                        bingoCard[rand1, rand2] = values[i];
                        Console.WriteLine("bingoCard[{0},{1}] = {2}", rand1, rand2, values[i]);
                        filled = false;
                        maxCheck = 0;
                    }
                    else
                    {
                        if (maxCheck < 100)
                        {
                            filled = true;
                            maxCheck += 1;
                        }
                        else
                        {
                            filled = false;
                            maxCheck = 0;
                        }

                    }
                } while (filled);
            }

            return bingoCard;

        }

        // Method to randomize user input if they enter more than 24 strings, because the first 24 will be used
        public static string[] Randomize2dStringArray(string[] array)
        {
            string[] newArray = new string[array.Length];
            int randArrayElement = rand.Next(0, array.Length - 1);

            for (int i = 0; i < array.Length; i++)
            {
                if (randArrayElement != 30)
                {
                    newArray[i] = array[randArrayElement];
                }
                else
                {
                    i -= 1;
                }

                if (randArrayElement < array.Length)
                {
                    randArrayElement += 1;
                }
                else
                {
                    randArrayElement = 0;
                }

            }
            return newArray;
        }

        static void Main(string[] args)
        {

            /*Console.WriteLine("Input # of entries: ");
            int numEntry = int.Parse(Console.ReadLine());

            string[] userInput = new string[numEntry];

            for (int i = 0; i < userInput.Length; i++)
            {
                Console.WriteLine("enter string: ");
                userInput[i] = Console.ReadLine();
            }*/

            string[] testArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24","25","26","27","28","29","30" };
            string[] randomizedTestArray = Randomize2dStringArray(testArray);
            /*for (int i = 0; i < randomizedTestArray.Length; i++)
            {
                Console.WriteLine("element {0} = {1}",i,randomizedTestArray[i]);
            }*/
            
            string[,] finishedBingoCard = RandomizeBingoCard(randomizedTestArray);

            // prints the array like a bingo card on the console
            int rowLength = finishedBingoCard.GetLength(0);
            int colLength = finishedBingoCard.GetLength(1);

            
            for(int t = 0; t < rowLength; t++)
            {
                for(int s = 0; s < colLength; s++)
                {
                    Console.Write("{0} ", finishedBingoCard[t, s]);
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

        }
    }
}
