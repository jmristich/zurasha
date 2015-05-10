using System.Collections.Generic;

namespace DungeonOfZurasha.Dungeon
{
    public class NonPlayerCharacter : Character 
    {
        public ICollection<Item> Items { get; set; }
    }
}