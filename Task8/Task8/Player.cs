using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Player
    {
        public string Name;
        public int Age;
        public Race race;

        public Player(string name, int age, Race race)
        {
            Name = name;
            Age = age;
            this.race = race;
        }

        public override bool Equals(object obj)
        {
            return obj is Player player &&
                   Name == player.Name &&
                   Age == player.Age &&
                   EqualityComparer<Race>.Default.Equals(race, player.race);
        }

        public override int GetHashCode()
        {
            int hashCode = -1907464294;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            hashCode = hashCode * -1521134295 + race.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"{Name} age - {Age} race - {race}";
        }

      
    }
}
