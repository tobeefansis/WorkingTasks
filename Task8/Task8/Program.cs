using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5;

namespace Task8
{
    class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            Menu menu = new Menu(
                new MenuItem("Task-1", Task1),
                new MenuItem("Task-2", Task2),
                new MenuItem("Task-3", Task3),
                new MenuItem("Task-4", Task4)
                );

        }
        static Action CreateAction()
        {
            int count = 0;
            return () =>
           {
               count++;
               Console.WriteLine("Count = {0}", count);
           };

        }
        private static void Task4()
        {


            var action = CreateAction();

            action();
            action();
            action();
            action();
            action();
            action();
        }

        private static void Task3()
        {

            Race ork = new Race("ОРК");
            Race Elf = new Race("Elf");
            Race Zombie = new Race("Zombie");

            DataBase dataBase = new DataBase(15);
            for (int i = 0; i < 4; i++)
            {
                dataBase.AddPlayers(
                    new Player("1" + r.Next(), 9, ork),
                    new Player("s" + r.Next(), 17, Elf),
                    new Player("d" + r.Next(), 20, Zombie),
                    new Player("s" + r.Next(), 10, Zombie),
                    new Player("b" + r.Next(), 4, ork)
                    ); ;
            }
            ConsoleLogger.StartBlock();
            ConsoleLogger.LogCenter("Список всех игроковю");
            dataBase.players.ForEach(ConsoleLogger.Log);
            ConsoleLogger.EndBlock();
            ConsoleLogger.StartBlock();

            ConsoleLogger.LogCenter("Игроки одной расы (любая произвольная раса из существующих).");
            dataBase.players
                .Where(n => n.race == ork)
                .ToList()
                .ForEach(ConsoleLogger.Log);
            ConsoleLogger.EndBlock();
            ConsoleLogger.StartBlock();

            ConsoleLogger.LogCenter("Игроки больше X уровня. X выбрать произвольно.");
            dataBase.players
                .Where(n => n.Age > 10)
                .ToList()
                .ForEach(ConsoleLogger.Log);
            ConsoleLogger.EndBlock();
            ConsoleLogger.StartBlock();
            ConsoleLogger.LogCenter("Игроки, чьи ники начинаются с определенной (произвольной) буквы.");
            dataBase.players
               .Where(n => n.Name[0] == 's')
               .ToList()
               .ForEach(ConsoleLogger.Log);

            int a = 7;
            int b = 20;
            ConsoleLogger.EndBlock();
            ConsoleLogger.StartBlock();
            ConsoleLogger.Log($"Игроки расы X с уровнем не больше чем A " +
                $"и игроки расы Y с уровнем не больше чем B. A, B, X, Y выбрать на свое усмотрение.");
            ConsoleLogger.Log($"A={a}, B={b}, X={ork}, Y={Elf}");
            dataBase.players
               .Where(n => (n.Age < a && n.race == ork) || (n.Age < b && n.race == Elf))
               .ToList()
               .ForEach(ConsoleLogger.Log);
            ConsoleLogger.EndBlock();
        }



        private static void Task2()
        {

            string[] emails = new string[]
            {
            "randommail@mail.ru",
            "someoneshere@gmail.by",
            "jackteller@gmail.com",
            "yellow.brick.records@mail.cz",
            "randommail2@mail.ru",
            "kidywalters999@gmail.com",
            "mail.trueman@mail.cz",
            "sol.goodman@gmail.com",
            "alfick.demon.44@mail.gv.cz"
            };
            ConsoleLogger.StartBlock();
            ConsoleLogger.LogCenter("Список всех");
            emails.ToList().ForEach(ConsoleLogger.Log);
            ConsoleLogger.EndBlock();
            var t = emails
                .Where(n => GetRegex(n) != "")
                .Select(n => GetRegex(n)
            ).Distinct().ToList();
            ConsoleLogger.StartBlock();
            t.ForEach(ConsoleLogger.Log);
            ConsoleLogger.EndBlock();
        }

        static string GetRegex(string text)
        {
            int index = text.LastIndexOf('@');

            return text.Substring(index, text.Length - index);
        }

        private static void Task1()
        {
            /*  Объявить тип User содержащий:
              • Имя пользователя
              • Возраст
              • Почтовый адрес
              • Конструктор с параметрами

              Создать коллекцию из 5 пользователей

              [Использовать LINQ]
              Создать List<User>, в который добавить только пользователей старше 13 лет и почтовые ящики у которых содержат символ @*/
            List<User> users = new List<User>()
            {
                new User("user 1",10,"asd@asd*a/d"),
                new User("user 2",30,"asdasdad"),
                new User("user 3",14,"asdas*dad"),
                new User("user 4",2,"asdasdad"),
                new User("user 5",7,"asdasdad")
            };
            ConsoleLogger.StartBlock();
            ConsoleLogger.LogCenter("Список всех");
            users.ForEach(ConsoleLogger.Log);
            ConsoleLogger.EndBlock();

            var select = users
                .Where(n => n.Age > 13 &&
                (n.PostalAddress.Contains("@") || n.PostalAddress.Contains("*") || n.PostalAddress.Contains("/"))
                )
                .ToList();
            ConsoleLogger.StartBlock();
            select.ForEach(ConsoleLogger.Log);
            ConsoleLogger.EndBlock();

        }
        class User
        {
            string name;
            int age;
            string postalAddress;

            public override string ToString()
            {
                return $"name {name}, age {age}, postal address {postalAddress}";
            }

            public User(string name, int age, string postalAddress)
            {
                this.Name = name;
                this.Age = age;
                this.PostalAddress = postalAddress;
            }

            public string Name { get => name; set => name = value; }
            public int Age { get => age; set => age = value; }
            public string PostalAddress { get => postalAddress; set => postalAddress = value; }
        }
    }
}





