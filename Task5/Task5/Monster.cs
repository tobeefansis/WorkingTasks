using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    public abstract class Monster
    {
        public string Name;
        public int Health;
        public int MaxHealth;
        public int Damage;
        public Armor Armor;
        public List<IItem> Items = new List<IItem>();

        public bool IsDead { get; private set; }

        public Action<Monster> OnDead;

        protected Monster(int health, int damage, Armor armor, string name, params IItem[] items)
        {
            Health = MaxHealth = health;
            Damage = damage;
            this.Armor = armor;
            this.Name = name;
            Items = items.ToList();
        }

        private void UseItem()
        {
            var index = Random.Next(0, Items.Count);
            Items[index].Use(this);
            if (!Items[index].Reusable)
            {
                Items.RemoveAt(index);
            }
        }

        public virtual void SetDamage(int damage)
        {
            damage = Armor.Blocking(damage);
            Health -= damage;
            ConsoleLogger.Log($"Монстор { Name} получил удар в {damage} очков атаки");
            if (Health <= 0)
            {
                Dead();
            }
        }

        public virtual int Hit()
        {
            var damage = Random.Range(Damage, 3);
            ConsoleLogger.Log($"Монстор { Name} нанес удар в {damage} очков атаки");
            return damage;
        }
        public void Dead()
        {

            ConsoleLogger.StartBlock(ConsoleColor.DarkMagenta);
            ConsoleLogger.LogCenter($"Умер", background: ConsoleColor.DarkMagenta);
            ConsoleLogger.LogCenter($"                █                ", background: ConsoleColor.DarkMagenta);
            ConsoleLogger.LogCenter($"             ▄▄▄█▄▄▄             ", background: ConsoleColor.DarkMagenta);
            ConsoleLogger.LogCenter($"                █                ", background: ConsoleColor.DarkMagenta);
            ConsoleLogger.LogCenter($"                █                ", background: ConsoleColor.DarkMagenta);
            ConsoleLogger.LogCenter($"                █                ", background: ConsoleColor.DarkMagenta);
            ConsoleLogger.LogCenter($"          ▄▄▄▄▄▄█▄▄▄▄▄▄          ", background: ConsoleColor.DarkMagenta);
            ConsoleLogger.LogCenter($"          █           █          ", background: ConsoleColor.DarkMagenta);
            ConsoleLogger.LogCenter($"          █    RIP    █          ", background: ConsoleColor.DarkMagenta);
            ConsoleLogger.LogCenter($"          █▄▄▄▄▄▄▄▄▄▄▄█          ", background: ConsoleColor.DarkMagenta);
            ConsoleLogger.LogCenter($"________▄▄█████████████▄▄________", background: ConsoleColor.DarkMagenta);
            ConsoleLogger.Log(this, background: ConsoleColor.DarkMagenta);
            ConsoleLogger.EndBlock(ConsoleColor.DarkMagenta);
            OnDead?.Invoke(this);
            IsDead = true;
            
        }

        public override string ToString()
        {
            return $"Монстор {Name}, у него жизненных очков {Health} из {MaxHealth}, очков атаки {Damage},";
        }
    }
}
