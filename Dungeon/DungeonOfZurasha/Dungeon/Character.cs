﻿using System;
using System.Collections.Generic;

namespace DungeonOfZurasha.Dungeon
{
    public abstract class Character
    {
        protected Character()
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
            private set
            {
                
            }
        }

        public int Defense
        {
            get
            {
                return Agility + Strength;
            }
            private set
            {
                
            }
        }

        public int Level { get; set; }

        //Making this a huge number to account for possible experience gains rising exponentially. This should probably never be below 0 either.
        public UInt32 Experience { get; set; }

        public Race Race { get; set; }
        public ClassType Type { get; set; }

        public Position Position { get; set; }
        public ICollection<Ability> Abilities {get;set;}
    }
}
