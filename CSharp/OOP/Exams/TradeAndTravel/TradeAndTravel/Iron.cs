namespace TradeAndTravel
{
    using System;
    using System.Linq;

    internal class Iron : Item
    {
        private const int IronValue = 3;

        public Iron(string name, Location location = null) : base(name, IronValue, ItemType.Iron, location)
        {
        }
    }
}