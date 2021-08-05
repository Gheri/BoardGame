namespace BGame.Interfaces
{
    // This is interface for all cell types of board
    public interface IBoardElement
    {
        public void ApplyStateChange(IPlayer player);
    }
}
