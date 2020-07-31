using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    public struct Armor
    {
        const int DamageBlockingRange = 4;
        public int DamageBlocking;
        public int Durability;
        public int MaxDurability;

        public Armor(int damageBlocking, int durability)
        {
            DamageBlocking = damageBlocking;
            Durability = MaxDurability = durability;
        }
        public static Armor GetRandom(int damageBlocking = 10, int durability = 5, int range = 5)
        {

            var DamageBlocking = Random.Range(damageBlocking, range);
            var Durability = Random.Range(durability, range);
            return new Armor(DamageBlocking, Durability);
        }
        public int Blocking(int damage)
        {
            Durability--;
            if (Durability > 0)
            {
                int block = Random.Range(damage, DamageBlockingRange);
                ConsoleLogger.Log($"Броня заблокировала {block} уронв при этом у нее осталось {Durability} из {MaxDurability} очков прочности"); ;
                return damage - block;

            }
            if (Durability == 0)
                ConsoleLogger.Log($"Броня не выдержала и сломалась");
            else
                ConsoleLogger.Log($"Броня не заблокировала ни одного очка"); ;
            return damage;
        }
    }
}
