namespace TradeAndTravel
{
    using System;
    using System.Linq;

    public class Wood : Item
    {
        private const int WoodValue = 2;

        public Wood(string name, Location location = null) : base(name, WoodValue, ItemType.Wood, location)
        {
        }

        public override void UpdateWithInteraction(string interaction)
        {
            switch (interaction)
            {
                case "drop":
                    this.DecreaseValue(this);
                    break;
                default:
                    break;
            }

            base.UpdateWithInteraction(interaction);
        }

        private void DecreaseValue(Wood wood)
        {
            if (this.Value > 0)
            {
                this.Value--;
            }
        }
    }
}