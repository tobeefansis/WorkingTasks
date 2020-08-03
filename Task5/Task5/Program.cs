using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5
{

    class Program
    {
        public static Random Random = new Random();
        static void Main(string[] args)
        {
            Menu menu = new Menu(
                new MenuItem("Play The Game", Play),
                new MenuItem("Одежда", Clothes),
                new MenuItem("Матиматека", Math)
                );
        }
        static void Math()
        {
            
            ConsoleLogger.StartBlock();
            ConsoleLogger.Log($" MyMath.Sum(1, 2, 3, 4, 5) = { MyMath.Sum(1, 2, 3, 4, 5)}");
            ConsoleLogger.Log($" MyMath.Sum(1, 2, 3, 4, 5f) = { MyMath.Sum(1, 2, 3, 4, 5f)}");
            ConsoleLogger.Log($" MyMath.Sum(1, 2, 3, 4, 5d) = { MyMath.Sum(1, 2, 3, 4, 5d)}");
            ConsoleLogger.Log($" MyMath.Sum(1, 2, 3, 4, 5d) = { MyMath.Sum(1, 2, 3, 4, 5m)}");
            ConsoleLogger.Log($" MyMath.Division(1, 2f) = {MyMath.Division(1, 2f)}");
            ConsoleLogger.Log($" MyMath.Factorial(5) = {MyMath.Factorial(5)}");
            ConsoleLogger.EndBlock();
        }
        private static void Clothes()
        {
            Hat NikeHat = new Hat(10, ConsoleColor.Green, "Nike");
            Boots Puma = new Boots(42, ConsoleColor.Gray, "Puma");
            Boots Nike = new Boots(44, ConsoleColor.Green, "Nike");
            Boots Rebook = new Boots(43, ConsoleColor.Red, "Rebook");
            Hat JohnTrigger = new Hat(5, ConsoleColor.Cyan, "JOHN TRIGGER");

            List<IEquipped> clothes = new List<IEquipped>();
            clothes.Add(Nike);
            clothes.Add(Rebook);
            clothes.Add(Puma);
            clothes.Add(JohnTrigger);
            clothes.Add(NikeHat);

            clothes.OrderBy(n => n.EquipType);

            foreach (var item in clothes)
            {
                item.ShowDescription();
            }
        }

        private static void Play()
        {
            FightController fight = new FightController(
                new Skeleton(10, 3,
                new Armor(20, 2), "Вася"),
                new Wolf(10, 3, 10,
                new Armor(20, 2), "Валера")
                );
            fight.Fight();
        }
    }
}
