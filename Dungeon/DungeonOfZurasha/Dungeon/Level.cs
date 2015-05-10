using System.Collections.Generic;

namespace DungeonOfZurasha.Dungeon
{
    public class Level
    {
        public ICollection<NonPlayerCharacter> Enemies { get; set; } 
        public ICollection<Tile> Tiles { get; set; }
    }
}