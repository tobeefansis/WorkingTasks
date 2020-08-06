using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    struct Race
    {
        public string Name { get; }

        public Race(string name)
        {
            Name = name;
        }


        public override string ToString()
        {
            return Name;
        }
        public static bool operator ==(Race a, Race b)
        {
            return a.Name == b.Name;
        }
        public static bool operator !=(Race a, Race b)
        {
            return a.Name != b.Name;
        }
        public override bool Equals(object obj)
        {
            return obj is Race race &&
                   Name == race.Name;
        }
    }
}
