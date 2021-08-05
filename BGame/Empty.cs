using BGame.Interfaces;

namespace BGame
{
    // this represents the Empty Cell Type
    public class Empty : IBoardElement
    {
        public void ApplyStateChange(IPlayer player)
        {
            // nothing happens in Empty State
        }
    }
}
