using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    internal class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Welcome to the Scoreboard Tracker!");

            Dictionary<string, int> scoreboards = new Dictionary<string, int>();

            while (true)
            {
                Console.WriteLine("\nPlease enter the team name and score separated by a space (e.g. 'Team A 5'), or enter 'quit' to exit:");

                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("Thanks for using the Scoreboard Tracker!");
                    break;
                }

                string[] inputArray = input.Split(' ');

                if (inputArray.Length != 2)
                {
                    Console.WriteLine("Invalid input. Please enter the team name and score separated by a space.");
                    continue;
                }

                string teamName = inputArray[0];
                int score;

                if (!int.TryParse(inputArray[1], out score))
                {
                    Console.WriteLine("Invalid score. Please enter a number for the score.");
                    continue;
                }

                if (scoreboards.ContainsKey(teamName))
                {
                    scoreboards[teamName] += score;
                }
                else
                {
                    scoreboards.Add(teamName, score);
                }

                Console.WriteLine("Scoreboard:");
                foreach (KeyValuePair<string, int> scoreboard in scoreboards)
                {
                    Console.WriteLine("{0}: {1}", scoreboard.Key, scoreboard.Value);
                }
            
            }
        }
    }
}

