using BGame.Interfaces;

namespace BGame
{
    // this represents the Hotel cell type
    public class Hotel : IHotel
    {
        private const int _hotelRentCharges = 50;

        private IPlayer _owner;

        public Hotel()
        {
            _owner = null;
        }

        public int WorthValue => 200;
        public void ApplyStateChange(IPlayer player)
        {
            if(_owner == null && player.Money >= WorthValue)
            {
                _owner = player;
                player.DeductMoney(WorthValue);
                player.AddHotel(this);

            } else if (_owner != null && _owner != player)
            {
                player.DeductMoney(_hotelRentCharges);
                _owner.AddMoney(_hotelRentCharges);
            }
        }
    }
}
