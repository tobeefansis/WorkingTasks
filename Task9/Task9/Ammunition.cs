using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public struct Ammunition
    {
        public string SoundOfShot { get; }
        public int Damage { get; }
        public int Range { get; }

        Ammunition(int damage, int range, string soundOfShot)
        {
            Damage = damage;
            Range = range;
            SoundOfShot = soundOfShot;
        }

        public override string ToString()
        {
            return $"{SoundOfShot} (был выстрел c уроном {Damage}, и на дистанцию {Range})";
        }
        public static Ammunition ArmorPiercing => new Ammunition(10, 4, "ба бах");
        public static Ammunition Tracing => new Ammunition(4, 6, "тра-та-та");
        public static Ammunition Discontinuous => new Ammunition(15, 2, "Тыдыщь");
    }
}
