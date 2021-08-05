using BGame.Interfaces;

namespace BGame
{
    // this represents the jail cell type
    public class Jail : IBoardElement
    {
        private const int _jailFine = 150;

        public void ApplyStateChange(IPlayer player)
        {
            player.DeductMoney(_jailFine);
        }
    }
}
