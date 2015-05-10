using System.Collections.Generic;

namespace DungeonOfZurasha.Dungeon
{
    public class Dungeon
    {
        //Main dungeon class for the game. Dungeon should have a reference to the player character?
        public PlayerCharacter Player { get; set; }
        public ICollection<Level> Levels { get; set; }
    }
}
