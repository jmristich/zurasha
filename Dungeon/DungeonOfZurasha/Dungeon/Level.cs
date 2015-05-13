using System.Collections.Generic;

namespace DungeonOfZurasha.Dungeon
{
    public class Level
    {
        public Level()
        {
            Enemies = new List<NonPlayerCharacter>();
            Tiles = new List<Tile>();
            Rooms = new List<Room>();
        }
        //Should there be a vendor on every level? Should hold reference, wether we create one or not can be done on generation though
        public NonPlayerCharacter Vendor { get; set; }
        public ICollection<NonPlayerCharacter> Enemies { get; set; }
        public ICollection<Tile> Tiles { get; set; }
        public ICollection<Room> Rooms { get; set; }

        public void GenerateEmptyLevel()
        {
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 40; j++)
                {

                    Tile tile = new Tile();
                    tile.Position.X = j;
                    tile.Position.Y = i;
                    if (i == 0 || i == 39 || j == 0 || j == 39)
                    {
                        tile.Type = TileType.MapBorder;
                    }
                    else
                    {
                        tile.Type = TileType.RockWall;
                    }
                    Tiles.Add(tile);
                }
            }
        }

        public void GenerateRooms()
        {
            for (int i = 0; i < 4; i++)
            {
                Room room = new Room();
                switch (i)
                {
                    case 0:
                        room.Start.X = 3;
                        room.Start.Y = 3;
                        room.Size.X = 9;
                        room.Size.Y = 9;
                        break;
                    case 1:
                        room.Start.X = 27;
                        room.Start.Y = 3;
                        room.Size.X = 9;
                        room.Size.Y = 9;
                        break;
                    case 2:
                        room.Start.X = 3;
                        room.Start.Y = 27;
                        room.Size.X = 9;
                        room.Size.Y = 9;
                        break;
                    case 3:
                        room.Start.X = 27;
                        room.Start.Y = 27;
                        room.Size.X = 9;
                        room.Size.Y = 9;
                        break;
                }

                //int x, y;
                foreach (Tile tile in Tiles)
                {
//                    x = room.Start.X + room.Size.X;
//                    y = room.Start.Y + room.Size.Y;
                    if (tile.Position.X >= room.Start.X && tile.Position.X <= room.Start.X + room.Size.X &&
                        tile.Position.Y >= room.Start.Y && tile.Position.Y <= room.Start.Y + room.Size.Y)
                    {
                        tile.Type = TileType.RoomFloor;
                        room.Tiles.Add(tile);
                    }
                }

                Rooms.Add(room);
            }

        }
    }
}