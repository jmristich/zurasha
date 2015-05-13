using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfZurasha.Dungeon
{
    public class Room
    {
        public Room()
        {
            Tiles = new List<Tile>();
        }

        public Room(Position start, Position size)
        {
            Start = start;
            Size = size;
            Tiles = new List<Tile>();
        }

        public ICollection<Tile> Tiles { get; set; }
        public Position Start { get; set; }
        public Position Size { get; set; }
    }
}
