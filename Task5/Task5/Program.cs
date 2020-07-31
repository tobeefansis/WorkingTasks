using System;

namespace Task5
{

    class Program
    {
        public static Random Random = new Random();
        static void Main(string[] args)
        {

            Menu menu = new Menu(
                new MenuItem("Play The Game", Play),
                new MenuItem("всякая хрень", Play),
                new MenuItem("всякая хрень", Play)
                );
        }

        private static void Play()
        {
            FightController fight = new FightController(
                new Skeleton(10, 3,
                new Armor(20, 2), "1"),
                new Skeleton(10, 3,
                new Armor(20, 2), "2")
                );
            fight.Fight();
        }
    }
}
