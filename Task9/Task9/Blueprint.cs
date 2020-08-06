using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task9.Properties;

namespace Task9
{
    public abstract class Blueprint
    {
        public abstract FactoryProduct Create();
    }

    public class TruckBlueprint : Blueprint
    {
        public TruckBlueprint(int speed)
        {
            Speed = speed;
        }

        public int Speed { get; set; }
        public override FactoryProduct Create()
        {
            return new Truck(Speed);
        }
    }
    public class TankBlueprint : Blueprint
    {
        public int Speed { get; set; }
        public Ammunition Ammunition { get; set; }

        public TankBlueprint(int speed, Ammunition defaultAmmo)
        {
            Speed = speed;
            Ammunition = defaultAmmo;
        }

        public override FactoryProduct Create()
        {
            return new Tank(Speed, Ammunition);
        }
    }
    public class TurretBlueprint : Blueprint
    {
        public Ammunition Ammunition { get; set; }

        public TurretBlueprint( Ammunition defaultAmmo)
        {
            Ammunition = defaultAmmo;
        }

        public override FactoryProduct Create()
        {
            return new Turret( Ammunition);
        }
    }
}
