using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    class Weapon : IItem
    {
        public int Damage;
        public string Name;

        public Weapon(string name, int damage, bool reusable = false)
        {
            Damage = damage;
            Reusable = reusable;
            Name = name;
        }

        public bool Reusable { get; private set; }

        public void Use(Monster monster)
        {
            monster.Damage += Random.Range(Damage, 4);
        }
    }
}
