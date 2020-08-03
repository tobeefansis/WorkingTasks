using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    public class Skeleton : Monster
    {
        public Skeleton(int health, int damage, Armor armor, string name, params IItem[] items) : base(health, damage, armor, name, items)
        {
        }

        public override int Hit()
        {
            var damage = Random.Range(Damage, 3);
            ConsoleLogger.Log($"Скелет { Name} нанес удар в {damage} очков атаки");
            return damage;
        }

        public override void SetDamage(int damage)
        {
            damage = Armor.Blocking(damage);
            Health -= damage;
            ConsoleLogger.Log($"Скелет { Name} получил удар в {damage} очков атаки");
            if (Health <= 0)
            {
                Dead();
            }

        }

        public override string ToString()
        {
            return $"Скелет {Name} у него жизненных очков {Health} из {MaxHealth}, очков атаки {Damage},";
        }
    }
}
