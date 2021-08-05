using BGame.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BGame
{
    // this represents the player playing the board game
    public class Player : IPlayer
    {
        private const int InitialAmount = 1000;

        private List<IHotel> _hotels = new List<IHotel>();
        public int PositionOnBoard { get; set; }
        public int Money { get; private set; }
        public int PId { get; private set; }
        public Player(int pId)
        {
            PId = pId;
            PositionOnBoard = -1;
            // hard code value for intial amount
            Money = InitialAmount;
        }

        public void AddMoney(int moneyToBeAdded)
        {
            Money = Money + moneyToBeAdded;
        }

        public void DeductMoney(int moneyToBeDeducted)
        {
            Money = Money - moneyToBeDeducted;
        }

        public void AddHotel(IHotel hotel)
        {
            _hotels.Add(hotel);
        }
        
        public int TotalWorthValue
        {
            get
            {
                var hotelValue = _hotels.Sum(x => x.WorthValue);
                return Money + hotelValue;
            }
        }
    }
}
