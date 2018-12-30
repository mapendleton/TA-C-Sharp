using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino;
using Casino.BlackJack;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of blackjack right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Matthew Pendleton\myProjects\TA-C-Sharp\BlackJack\BlackJack\Logs\logs.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new BlackJackGame();
                game += player;
                player.IsActivelyPlaying = true;
                while(player.IsActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }

    }
}
