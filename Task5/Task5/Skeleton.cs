using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    public class Skeleton : Monster
    {
        public Skeleton(int health, int damage, Armor armor, string name) : base(health, damage, armor, name)
        {
        }

        public override int Hit()
        {
            return base.Hit();
        }

        public override void SetDamage(int damage)
        {
            base.SetDamage(damage);
        }

        public override string ToString()
        {
            return $"Скелет {Name} у него жизненных очков {Health} из {MaxHealth}, очков атаки {Damage},";
        }
    }
}
