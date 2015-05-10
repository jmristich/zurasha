using System;

namespace DungeonOfZurasha.Dungeon
{
    public class PlayerCharacter : Character
    {
        public PlayerCharacter() {
            Inventory = new Inventory();
            Experience = 0;
        }

        public Inventory Inventory { get; set; }
        //Making this a huge number to account for possible experience gains rising exponentially. This should probably never be below 0 either.
        public UInt64 Experience { get; set; }


        public void PickUpItem(Item item)
        {
            if (Inventory.TotalWeight > Strength * 2)
            {
                //player can't pick up, notify UI of overburden
            }
            else
            {
                Inventory.Items.Add(item);
            }
        }

        public void DropItem(Item item)
        {
            Inventory.Items.Remove(item);
        }

        public void GainExperience(int experience)
        {
            Experience += Convert.ToUInt64(experience);

            //probably need some sort of mapping or algorithm for the xp needed per level
            //if (Experience == enough for new level) {
            //level++;
            //}
        }

        public void Heal(int healthGained)
        {
            Health += healthGained;
        }

        public void Drink(int manaGained)
        {
            Mana += manaGained;
        }

        public void UseAbility(Ability ability)
        {
            if (ability.ManaCost.HasValue)
            {
                if (Mana >= ability.ManaCost.Value)
                {
                    //use ability
                }
                else
                {
                    //not enough mana message!
                }
            }
            else
            {
                //use ability
            }
        }
        public void TakeDamage(int damageTaken)
        {
            Health -= damageTaken;
            if (Health < 0)
            {
                //player has died, end game, and return to loading screen?
            }
        }

        public void MoveUp()
        {
            Position.Y++;
        }

        public void MoveDown()
        {
            Position.Y--;
        }

        public void MoveLeft()
        {
            Position.X--;
        }

        public void MoveRight() 
        {
            Position.X++;
        }
    }
}