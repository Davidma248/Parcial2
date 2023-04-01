using Character;
using System;

public class CharacterC
{
    public enum CharacterClass { Human, Beast, Hybrid, }

    public class player
    {
        public string Name { get; }
        public int HealthPoints { get; private set; }
        public int AttackPointsBase { get; }
        public int DefensePointsBase { get; }
        public Weapon EquippedWeapon { get; private set; }
        public Armor EquippedArmor { get; private set; }

    }   

    }
}