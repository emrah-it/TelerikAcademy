namespace TradeAndTravel
{
    using System;
    using System.Linq;

    internal class Weapon : Item
    {
        private const int WeaponValue = 10;

        public Weapon(string name, Location location = null) : base(name, WeaponValue,ItemType.Weapon, location)
        {
        }
    }
}