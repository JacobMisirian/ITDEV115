// Written by Jacob Misirian
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class FarmerGame
    {
        public List<Item> NorthBank { get { return northBank; } }
        private List<Item> northBank = new List<Item>()
        {
            { Item.Chicken },
            { Item.Farmer },
            { Item.Grain },
            { Item.Fox }
        };

        public List<Item> SouthBank { get { return southBank; } }
        private List<Item> southBank = new List<Item>();

        public Direction FarmerDirection { get { return farmerDirection; } }
        private Direction farmerDirection = Direction.North;

        public bool ChickenAteGrain()
        {
            return (northBank.Contains(Item.Chicken) && northBank.Contains(Item.Grain) && !northBank.Contains(Item.Farmer)) || (southBank.Contains(Item.Chicken) && southBank.Contains(Item.Grain) && !southBank.Contains(Item.Farmer));
        }

        public bool FoxAteChicken()
        {
            return (northBank.Contains(Item.Fox) && northBank.Contains(Item.Chicken) && !northBank.Contains(Item.Farmer)) || (southBank.Contains(Item.Fox) && southBank.Contains(Item.Chicken) && !southBank.Contains(Item.Farmer));
        }

        public bool DetermineWin()
        {
            return northBank.Count <= 0;
        }

        public bool DetermineLoss()
        {
            return ChickenAteGrain() || FoxAteChicken();
        }

        public void Move(Direction direction, Item item)
        {
            farmerDirection = direction;
            if (item == Item.Nothing)
            {
                switch (direction)
                {
                    case Direction.North:
                        southBank.Remove(Item.Farmer);
                        northBank.Add(Item.Farmer);
                        break;
                    case Direction.South:
                        northBank.Remove(Item.Farmer);
                        southBank.Add(Item.Farmer);
                        break;
                }
            }
            else
                switch (direction)
                {
                    case Direction.North:
                        southBank.Remove(item);
                        southBank.Remove(Item.Farmer);
                        northBank.Add(item);
                        northBank.Add(Item.Farmer);
                        break;
                    case Direction.South:
                        northBank.Remove(item);
                        northBank.Remove(Item.Farmer);
                        southBank.Add(item);
                        southBank.Add(Item.Farmer);
                        break;
                }
        }
    }

    public enum Direction
    {
        North,
        South
    }

    public enum Item
    {
        Farmer,
        Chicken,
        Fox,
        Grain,
        Nothing
    }
}
