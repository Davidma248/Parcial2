using Character;

public enum WeaponClass { Human, Beast, Hybrid, Any }

public class Weapon
{
    public string Name { get; }
    public int Power { get; private set; }
    public int AttackPointsBase { get; }
    public int DefensePointsBase { get; }
    public Weapon EquippedWeapon { get; private set; }
    public Armor EquippedArmor { get; private set; }