namespace BGame.Interfaces
{
    public interface IInputReader
    {
        int NumberOfPlayers { get; }
        char[] Cells { get; }
        int[] DiceInput { get; }
    }
}
