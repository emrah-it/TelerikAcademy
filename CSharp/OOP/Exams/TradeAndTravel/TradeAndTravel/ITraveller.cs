namespace TradeAndTravel
{
    using System;
    using System.Linq;

    public interface ITraveller
    {
        Location Location { get; }

        void TravelTo(Location location);
    }
}