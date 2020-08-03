using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    public class Wolf : Monster
    {
        private int teethCount;
        public Wolf(int health, int damage, int teethCount, Armor armor, string name) : base(health, damage, armor, name, new IItem[0])
        {
            TeethCount = teethCount;
        }

        public int TeethCount
        {
            get => teethCount;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    teethCount = value;
                }
            }
        }

        public override int Hit()
        {
            int damage = (int)(Damage * TeethCount * 0.45f);
            ConsoleLogger.Log($"Волк { Name} нанес удар в {damage} очков атаки, используя зубы в количестве {TeethCount}");
            return damage;
        }

        public override void SetDamage(int damage)
        {
            damage = Armor.Blocking(damage);
            Health -= damage;
            ConsoleLogger.Log($"Волк { Name} получил удар в {damage} очков атаки");
            if (Health <= 0)
            {
                Dead();
            }

        }

        public override string ToString()
        {
            return $"Волк {Name} у него жизненных очков {Health} из {MaxHealth}, очков атаки {Damage} и количество зубов {TeethCount},";
        }
    }
}
