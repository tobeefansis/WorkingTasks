using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public class Turret : FactoryProduct, IShoteble
    {
        public Turret(Ammunition ammunition)
        {
            Ammunition = ammunition;
        }

        public Ammunition Ammunition { get; private set; }

        public void ChangeAmmunition(Ammunition ammo)
        {
            Ammunition = ammo;

        }
        public override object Clone()
        {
            return new Turret(Ammunition);
        }
        public void Shot()
        {
            ConsoleLogger.StartBlock();
            ConsoleLogger.Log("Турель сделал выстрел");
            ConsoleLogger.Log(Ammunition);
            ConsoleLogger.EndBlock();
        }
    }
}
