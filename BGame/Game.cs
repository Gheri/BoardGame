using BGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BGame
{
    public class Game
    {
        private List<IPlayer> _players = new List<IPlayer>();
        private IBoard _board;

        public Game(int numberOfPlayers, char[] cells)
        {
            // create board with given cells
            _board = new Board(cells);

            // create players
            for (int k = 0; k < numberOfPlayers; k++)
            {
                _players.Add(new Player(k + 1));
            }
        }

        public IDictionary<int, int> Play(int[] diceInput)
        {
            // start/play the game
            for (int i = 0, j = 0; i < diceInput.Length; i++)
            {
                _board.MovePlayerBy(_players[j++], diceInput[i]);
                if (j == _players.Count)
                {
                    j = 0;
                }
            }

            IDictionary<int, int> playerVsWorthValues = new Dictionary<int, int>();

            foreach(var player in _players)
            {
                playerVsWorthValues[player.PId] = player.TotalWorthValue;
            }
            return playerVsWorthValues;
        }
    }
}
