using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9.Properties
{
    public class Truck : FactoryProduct, IMoveble
    {
        public Truck(int speed)
        {
            Speed = speed;
        }

        public int Speed { get; set; }

        public override object Clone()
        {
            return new Truck(Speed);
        }

        public void Move()
        {
            ConsoleLogger.StartBlock();
            ConsoleLogger.Log($"Грузовик едет со скоростью {Speed}");
            ConsoleLogger.EndBlock();
        }


    }
}
