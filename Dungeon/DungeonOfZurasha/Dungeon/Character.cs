using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfZurasha.Dungeon
{

    private enum ClassType {
        Warrior, 
        Wizard,
        Rogue,
        //TODO: Come up with more possible classes if desired, maybe unique enemy class type?
    }

    private enum Race
    {
        Human, 
        Orc, 
        Imp,
        Dwarf,
        Elf
    }

    public class Ability 
    {
        public string Name { get; set; }
    }

    protected sealed class Character
    {
        public Character()
        {
            Experience = 0;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }

        //Core Stats - Speed based off Agility, Defense off Strength and Agility, maybe?
        public int Agility { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        //I think this will work, but gives you an idea of how to make a computed property that is gettable but not settable.
        public int Speed
        {
            get
            {
                return Agility * 2;
            }
            private set;
        }

        public int Defense
        {
            get
            {
                return Agility + Strength;
            }
            private set;
        }

        public int Level { get; set; }

        //Making this a huge number to account for possible experience gains rising exponentially. This should probably never be below 0 either.
        public UInt32 Experience { get; set; }

        public Race Race { get; set; }
        public ClassType Type { get; set; }

        public Position Position { get; set; }
        public ICollection<Ability> Abilities {get;set;}
    }

    public class PlayerCharacter : Character
    {
        public Inventory Inventory { get; set; }
    }

    public class NonPlayerCharacter : Character 
    {
        //Maybe we'll spawn monsters with special items on them so they drop and can be looted?
        public ICollection<Item> Items { get; set; }
    }

    public class Item
    {
        public string Name { get; set; }

        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }

        public int Damage { get; set; }
        public int Dodge { get; set; }

        public int Weight { get; set; }
    }

    public class Inventory
    {
        public ICollection<Item> Items { get; set; }
    }

    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
