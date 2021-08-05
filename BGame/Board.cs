using System.Collections.Generic;
using BGame.Interfaces;

namespace BGame
{
    // this represents the Game Board 
    public class Board: IBoard
    {
        private List<IBoardElement> _boardElements = new List<IBoardElement>();
        private readonly int _totalPositions;
        public Board(char[] boardIndices)
        {
            for (int j = 0; j < boardIndices.Length; j++)
            {
                if (boardIndices[j] == 'H')
                {
                    _boardElements.Add(new Hotel());
                }
                else if (boardIndices[j] == 'E')
                {
                    _boardElements.Add(new Empty());
                }
                else if (boardIndices[j] == 'J')
                {
                    _boardElements.Add(new Jail());
                }
                else if (boardIndices[j] == 'T')
                {
                    _boardElements.Add(new Treasure());
                }
            }
            _totalPositions = _boardElements.Count;
        }

        public void MovePlayerBy(IPlayer player, int position)
        {
            var positionOnBoard = (player.PositionOnBoard + position) % _totalPositions;
            player.PositionOnBoard = positionOnBoard;
            if(_boardElements.Count > positionOnBoard)
            {
                _boardElements[positionOnBoard].ApplyStateChange(player);
            }
        }
    }
}
