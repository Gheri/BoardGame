namespace BGame.Interfaces
{
    public interface IPlayer
    {
        int PId { get;}
        int PositionOnBoard { get; set; }
        int TotalWorthValue { get; }
        int Money { get; }
        void AddMoney(int moneyToBeAdded);
        void DeductMoney(int moenyToBeSubstracted);
        void AddHotel(IHotel hotel);
    }
}
