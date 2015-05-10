using System.Collections.Generic;

namespace DungeonOfZurasha.Dungeon
{
    public class Level
    {
        public Level()
        {
            Enemies = new List<NonPlayerCharacter>();
            Tiles = new List<Tile>();
        }
        //Should there be a vendor on every level? Should hold reference, wether we create one or not can be done on generation though
        public NonPlayerCharacter Vendor { get; set; }
        public ICollection<NonPlayerCharacter> Enemies { get; set; } 
        public ICollection<Tile> Tiles { get; set; }
    }
}