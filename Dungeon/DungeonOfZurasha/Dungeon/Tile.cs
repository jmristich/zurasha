using System.Collections.Generic;

namespace DungeonOfZurasha.Dungeon
{
    public enum TileType
    {
        DebugWall,
        MapBorder,
        RockWall,
        RoomFloor,
        HallFloor,
    }

    public class Tile
    {
        public Tile()
        {
            Items = new List<Item>();
        }

        //overloading the constructor, maybe level will pass in the position and type of the tile for it
        public Tile(Position position, TileType type)
        {
            Position = position;
            Items = new List<Item>();
            Type = type;
        }

        public bool HasItem { get; set; }
        //make it a collection just in case we want to add multiple items on a single tile?
        public ICollection<Item> Items { get; set; }

        public bool HasNonPlayerCharacter { get; set; }
        public NonPlayerCharacter NonPlayerCharacter { get; set; }

        public TileType Type { get; set; }
        public Position Position { get; set; }

        //hardness will be used for dijkstras to calculate monster movements
        public int Hardness { get; set; }
    }
}