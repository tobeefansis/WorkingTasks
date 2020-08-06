using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public class Tank : FactoryProduct, IShoteble, IMoveble
    {
        public Tank(int speed, Ammunition ammunition)
        {
            Speed = speed;
            Ammunition = ammunition;
        }

        public int Speed { get; set; }

        public Ammunition Ammunition { get; private set; }


        public void ChangeAmmunition(Ammunition ammo)
        {
            Ammunition = ammo;
        }

        public override object Clone()
        {
            return new Tank(Speed, Ammunition);
        }

        public void Move()
        {
            ConsoleLogger.StartBlock();
            ConsoleLogger.Log($"Танк едет со скоростью {Speed}");
            ConsoleLogger.EndBlock();
        }

        public void Shot()
        {
            ConsoleLogger.StartBlock();
            ConsoleLogger.Log("Танк сделал выстрел");
            ConsoleLogger.Log(Ammunition);
            ConsoleLogger.EndBlock();
        }
    }
}
