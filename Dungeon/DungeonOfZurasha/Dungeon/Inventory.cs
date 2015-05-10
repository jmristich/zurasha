using System.Collections.Generic;
using System.Linq;

namespace DungeonOfZurasha.Dungeon
{
    public class Inventory
    {
        public Inventory()
        {
            Items = new List<Item>();
        }
        public int TotalWeight 
        { 
            get
            {
                return Items.Sum(i => i.Weight);
            } 
            private set
            {
            } 
        }
        public ICollection<Item> Items { get; set; }
    }
}