using BGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BGame
{
    public class InputReader : IInputReader
    {
        public int NumberOfPlayers { get; }
        public char[] Cells { get; }
        public int[] DiceInput { get; }

        public InputReader(string txtFile)
        {
            string[] lines = System.IO.File.ReadAllLines(txtFile);

            NumberOfPlayers = int.Parse(lines[0]);

            Cells = lines[1].Split(',').Select(x => char.Parse(x)).ToArray();

            DiceInput = lines[2].Split(',').Select(x => int.Parse(x)).ToArray();
        }
    }
}
