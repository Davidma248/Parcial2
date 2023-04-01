using System;

namespace Character
{
    public enum ArmorClass
    {
        Helmet,
        Breastplate,
        Greaves,
        Shield,
        Any,
    }

    public class Armor
    {
        public string name { get; set; }
        public int Def { get; set; }
        public int Durability { get; set; }
        public ArmorClass Clase { get; set; }

        public Armor(string name, int def, int Durability, ArmorClass clase)
        {
            name = name;
            Def = def;
            Durability = Durability;
            Clase = clase;
        }

        public void RecibirDano(int dano)
        {
            int danoReduccion = Math.Max(1, dano / 2); // Se redondea hacia abajo
            Durability -= danoReduccion;
        }
    }
}
