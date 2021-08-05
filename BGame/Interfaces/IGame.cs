using System.Collections.Generic;

namespace BGame.Interfaces
{
    public interface IGame
    {
        // play the game and return the final scores
        IDictionary<int, int> Play(int[] diceInput);
    }
}
