using BGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BGame
{
    class Program
    {
        static void Main(string[] args)
        {
            InputReader reader = new InputReader(@"..\..\..\input.txt");
            
            var game = new Game(reader.NumberOfPlayers, reader.Cells);
            var playerVsWorthValues = game.Play(reader.DiceInput);

            // display final worth values
            var playerVsWorthValuesInDesc = playerVsWorthValues.OrderByDescending(x => x.Value).ToDictionary(z => z.Key, y => y.Value);
            foreach(KeyValuePair<int,int> entry in playerVsWorthValuesInDesc)
            {
                Console.WriteLine("Player - " + entry.Key + " has total worth " + entry.Value);
            }

            Console.ReadLine();
        }
    }
}
