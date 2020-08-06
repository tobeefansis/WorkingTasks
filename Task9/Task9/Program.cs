using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task9.Properties;

namespace Task9
{
    class Program
    {
        static TruckBlueprint truckBlueprint = new TruckBlueprint(10);
        static TankBlueprint tankBlueprint = new TankBlueprint(6, Ammunition.ArmorPiercing);
        static TurretBlueprint turretBlueprint = new TurretBlueprint(Ammunition.Tracing);
        static Factory factory = new Factory(tankBlueprint);
        static void Main(string[] args)
        {
            Menu menu = new Menu(
                new MenuItem("Создать танк", CreateTank),
                new MenuItem("Создать танк на основе другого", CreateTankCopy),
                new MenuItem("Создать турель", CreateTurret),
                new MenuItem("Создать турель на основе другого", CreateTurretCopy),
                new MenuItem("Создать грузовик", CreateTruck),
                new MenuItem("Создать грузовик на основе другого", CreateTruckCopy)
                );
        }

        private static void CreateTruckCopy()
        {
            factory.ChangeBlueprint(truckBlueprint);
            Truck original = (Truck)factory.Build();

            Truck truck = (Truck)factory.CreateCopy(original);

            truck.Move();
        }

        private static void CreateTurretCopy()
        {
            factory.ChangeBlueprint(turretBlueprint);
            Turret original = (Turret)factory.Build();

            Turret turret = (Turret)factory.CreateCopy(original);

            turret.Shot();
            turret.ChangeAmmunition(Ammunition.Discontinuous);
            turret.Shot();
            turret.ChangeAmmunition(Ammunition.ArmorPiercing);
            turret.Shot();
        }

        private static void CreateTankCopy()
        {
            factory.ChangeBlueprint(tankBlueprint);
            var original = (Tank)factory.Build();

            Tank tank = (Tank)factory.CreateCopy(original);

            tank.Shot();
            tank.ChangeAmmunition(Ammunition.Discontinuous);
            tank.Shot();
            tank.ChangeAmmunition(Ammunition.Tracing);
            tank.Shot();

            tank.Move();
        }

        private static void CreateTurret()
        {
            factory.ChangeBlueprint(turretBlueprint);
            Turret turret = (Turret)factory.Build();

            turret.Shot();
            turret.ChangeAmmunition(Ammunition.Discontinuous);
            turret.Shot();
            turret.ChangeAmmunition(Ammunition.ArmorPiercing);
            turret.Shot();
        }

        private static void CreateTruck()
        {
            factory.ChangeBlueprint(truckBlueprint);
            Truck truck = (Truck)factory.Build();

            truck.Move();
        }

        private static void CreateTank()
        {
            factory.ChangeBlueprint(tankBlueprint);
            Tank tank = (Tank)factory.Build();
            tank.Shot();
            tank.ChangeAmmunition(Ammunition.Discontinuous);
            tank.Shot();
            tank.ChangeAmmunition(Ammunition.Tracing);
            tank.Shot();

            tank.Move();
        }
    }
}
