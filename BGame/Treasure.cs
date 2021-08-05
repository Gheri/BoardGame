using BGame.Interfaces;

namespace BGame
{
    // This represents the treasure cell type
    public class Treasure : IBoardElement
    {
        private const int _treasureAmt = 200;

        public void ApplyStateChange(IPlayer player)
        {
            player.AddMoney(_treasureAmt);
        }
    }
}
