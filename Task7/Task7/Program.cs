using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*♦ Создать класс или структуру Vector2
		
		• Объявить поля/свойства для хранения координат X, Y
		• Создать конструктор с параметрами
		• Перегрузить операторы +, -, ++, --, ==, !=
		• Переопределить методы GetHashCode, Equals, ToString
		• Создать 2 открытых статических поля, характеризующих нулевой(0, 0) и единичный(0, 1) векторы*/
namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu menu = new Menu(
                new MenuItem("Task1", Task1),
                new MenuItem("Task2", Task2),
                new MenuItem("Task3", Task3)
                );
        }

        private static void Task3()
        {
            Application application= new Application();

            for (int i = 0; i < 10; i++)
            {
                User user = new User();
                user.ListenUpdates(application);
            }

            Admin admin = new Admin();
            application.CreateUpdate(admin.AccountType, "First Update", "Update Description");
        }

        private static void Task2()
        {
            List<Skeleton> skeletons = new List<Skeleton>();

            for (int i = 0; i < 10; i++)
            {
                Skeleton scelet = new Skeleton();
                scelet.OnDeath += Observer.AddListener;
                skeletons.Add(scelet);
            }

            foreach (var item in skeletons)
            {
                item.Kill();
            }
        }

        private static void Task1()
        {
            Vector2 a = new Vector2(1, 2);
            Vector2 b = new Vector2(2, 1);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine($"a + b {a + b}");
            Console.WriteLine($"a - b {a - b}");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine($"--a {--a }");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine($"++a  {++a }");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine($"a == b {a == b}");
            Console.WriteLine($"a != b {a != b}");
        }
    }
}
