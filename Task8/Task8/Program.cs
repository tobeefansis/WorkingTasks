using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        /*     Main
         • Создать игроков(с произвольными никнеймами, уровнем и расой)
         • Создать базу данных
         • Добавить игроков в базу данных
         [LINQ]
         Сформировать из игроков, находящихся в базе данных, следующие выборки:
         • Игроки одной расы(любая произвольная раса из существующих)
         • Игроки больше X уровня.X выбрать произвольно.
         • Игроки, чьи ники начинаются с определенной (произвольной) буквы
         • Игроки расы X с уровнем не больше чем A и игроки расы Y с уровнем не больше чем B.A, B, X, Y выбрать на свое усмотрение.*/
        static Random r = new Random();
        static void Main(string[] args)
        {
            Race ork = new Race("ОРК");
            Race Elf = new Race("Elf");
            Race Zombie = new Race("Zombie");

            DataBase dataBase = new DataBase(15);
            for (int i = 0; i < 3; i++)
            {
                dataBase.AddPlayers(
                    new Player("1" + r.Next(), 10, ork),
                    new Player("s" + r.Next(), 10, Elf),
                    new Player("d" + r.Next(), 10, Zombie),
                    new Player("s" + r.Next(), 10, Zombie),
                    new Player("b" + r.Next(), 10, ork)
                    ); ;
            }


            dataBase.players
                .Where(n => n.race.Name == ork.Name)
                .ToList()
                .ForEach(n => Console.WriteLine(n));
            dataBase.players
                .Where(n => n.Age > 10)
                .ToList()
                .ForEach(n => Console.WriteLine(n));
            dataBase.players
               .Where(n => n.Name[0] == 's')
               .ToList()
               .ForEach(n => Console.WriteLine(n));
            int a = 10;
            int b = 10;

            dataBase.players
           .Where(n => (n.Age < a && n.race.Name == ork.Name) || (n.Age < b && n.race.Name == Elf.Name))
           .ToList()
           .ForEach(n => Console.WriteLine(n));

        }
    }
}
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
}
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
class DataBase
{
    public int maxCount;
    public List<Player> players = new List<Player>();

    public DataBase(int maxCount)
    {
        this.maxCount = maxCount;
    }

    public void AddPlayers(params Player[] player)
    {
        foreach (var item in player)
        {
            AddPlayer(item);
        }
    }

    public void AddPlayer(Player player)
    {
        if (players.Count < maxCount && !IsNickNameExists(player.Name))
        {
            players.Add(player);
        }
        else
        {
            Console.WriteLine($"Такой ник уже есть или не хватает места- {player.Name}");
        }
    }

    bool IsNickNameExists(string nickname)
    {
        return players.Where(n => n.Name == nickname).ToList().Count != 0;
    }
}

/*
    Создать класс DataBase
    [Информация] Модификаторы доступа и сигнатуру(поле или свойство) выбрать на свое усмотрение
    • Максимальный размер базы данных(целое число)
    • Коллекция для хранения объектов типа Player
    • Конструктор, инициализирующий максимальный размер базы данных
    • Открытый метод void AddPlayers(X) для добавления игроков.Вместо X — возможность принимать в качестве параметра любое количество объектов типа Player.
        • Учесть в базе данных возможность нехватки места (превышение макс. размера базы)
        • Учесть возможность наличия такого никнейма в базе до его добавления(реализовать с использованием следующего метода)
    • Закрытый метод bool IsNickNameExists(string nickname) возвращающий true если такой ник уже есть в базе, false - иначе

   
*/
