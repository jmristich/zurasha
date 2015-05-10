using System.Collections.Generic;

namespace DungeonOfZurasha.Dungeon
{
    public class NonPlayerCharacter : Character 
    {
        public NonPlayerCharacter()
        {
            Items = new List<Item>();
        }

        public ICollection<Item> Items { get; set; }
    }
}