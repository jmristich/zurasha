using System.Collections.Generic;

namespace DungeonOfZurasha.Dungeon
{
    public enum TileType
    {
        
    }
    public class Tile
    {
        public bool HasItem { get; set; }
        //make it a collection just in case we want to add multiple items on a single tile?
        public ICollection<Item> Items { get; set; }

        public bool HasNonPlayerCharacter { get; set; }
        public NonPlayerCharacter NonPlayerCharacter { get; set; }

        public TileType Type { get; set; }
        public Position Position { get; set; }
    }
}