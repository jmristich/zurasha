namespace DungeonOfZurasha.Dungeon
{
    public class Ability 
    {
        public string Name { get; set; }

        //nullable int, some abilities might not have a mana cost
        public int? ManaCost { get; set; }

        //If we do leveling up abilities, we should have a mapping for this as well? Otherwise, we can just randomize the dmg of the ability for some number between min/max if desired, maybe do some sort of weighting, or critical strike potential (dmg * 1.5 or 2)
        //public int Level { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
    }
}