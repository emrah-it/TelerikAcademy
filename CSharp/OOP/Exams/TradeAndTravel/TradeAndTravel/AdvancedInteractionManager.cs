namespace TradeAndTravel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class AdvancedInteractionManager : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    item = base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
                    break;
            }

            return item;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location item;

            switch (locationTypeString)
            {
                case "mine":
                    item = new Mine(locationName);
                    break;
                case "forest":
                    item = new Forest(locationName);
                    break;
                default:
                    item = base.CreateLocation(locationTypeString, locationName);
                    break;
            }

            return item;
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    this.HandleGatherOperation(commandWords, actor);
                    break;
                case "craft":
                    this.HandleCraftOperation(commandWords, actor);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            switch (personTypeString)
            {
                case "merchant":
                    return new Merchant(personNameString, personLocation);
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
        }

        private void HandleGatherOperation(string[] commandWords, Person actor)
        {
            List<Item> actorItems = actor.ListInventory();
            Item newItem = null;
            switch (actor.Location.LocationType)
            {
                case LocationType.Mine:
                    if (this.ContainItem(actorItems, ItemType.Armor))
                    {
                        newItem = this.CreateItem(ItemType.Iron.ToString().ToLower(), commandWords[2], null, newItem);
                        this.AddToPerson(actor, newItem);
                    }

                    break;
                case LocationType.Forest:
                    if (this.ContainItem(actorItems, ItemType.Weapon))
                    {
                        newItem = this.CreateItem(ItemType.Wood.ToString().ToLower(), commandWords[2], null, newItem);
                        this.AddToPerson(actor, newItem);
                    }

                    break;
                default:
                    break;
            }
        }

        private bool ContainItem(List<Item> actorItems, ItemType itemType)
        {
            foreach (var item in actorItems)
            {
                if (item.ItemType == itemType)
                {
                    return true;
                }
            }

            return false;
        }

        private void HandleCraftOperation(string[] commandWords, Person actor)
        {
            List<Item> actorItems = actor.ListInventory();
            Item newItem = null;
            switch (commandWords[2])
            {
                case "armor":
                    if (this.ContainItem(actorItems, ItemType.Iron))
                    {
                        newItem = this.CreateItem(ItemType.Armor.ToString().ToLower(), commandWords[3], null, newItem);
                        this.AddToPerson(actor, newItem);
                    }

                    break;
                case "weapon":
                    if (this.ContainItem(actorItems, ItemType.Iron) && this.ContainItem(actorItems, ItemType.Wood))
                    {
                        newItem = this.CreateItem(ItemType.Weapon.ToString().ToLower(), commandWords[3], null, newItem);
                        this.AddToPerson(actor, newItem);
                    }

                    break;
                default:
                    break;
            }
        }
    }
}