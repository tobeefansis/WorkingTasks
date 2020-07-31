using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Menu
{
    List<MenuItem> items = new List<MenuItem>();

    public Menu(params MenuItem[] obj)
    {
        this.items = obj.ToList();
        while (true)
        {
            Reset();
        }
    }

    public void Reset()
    {
        ShowTasks();
        Console.WriteLine("Введите номер пункта:");
        string str = Console.ReadLine();
        try
        {
            var index = int.Parse(str);
            items[index - 1]?.OnClick();
            Console.WriteLine("Нажмите чтобы продолжить");
            Console.ReadLine();

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private void ShowTasks()
    {
        int w = 60;
        string up = "┌";
        string down = "└";
        for (int i = 0; i < w - 2; i++)
        {
            down += "─";
            up += "─";
        }
        up += "┐";
        down += "┘";
        Console.WriteLine(up);
        Console.WriteLine($"│{$" выберите нужный пункт:",-58}│");
        for (int i = 1; i <= items.Count; i++)
        {
            Console.WriteLine($"│{$" {i} {items[i - 1]}",-58}│");
        }
        Console.WriteLine(down);
    }
}

public class MenuItem
{
    private string name;
    private Action onClick;

    public override string ToString()
    {
        return Name;
    }
    public string Name { get => name; set => name = value; }
    public Action OnClick { get => onClick; set => onClick = value; }

    public MenuItem(string name, Action onClick)
    {
        this.name = name;
        OnClick = onClick;
    }
}
