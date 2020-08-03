using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    class Hat : IEquipped
    {
        EquipType _equipType = EquipType.Legs;
        public int Size;
        public ConsoleColor Color;
        public string Name;
        public EquipType EquipType { get => _equipType; }



        public Hat(int size, ConsoleColor color, string name)
        {
            Size = size;
            Color = color;
            Name = name;
        }

        public override string ToString()
        {
            return $"Головной убор {Name} {Size} размера, {Color}";
        }

        public void ShowDescription()
        {
            ConsoleLogger.StartBlock(ConsoleColor.DarkGray);
            ConsoleLogger.Log(ToString(), Color, ConsoleColor.DarkGray);
            ConsoleLogger.EndBlock(ConsoleColor.DarkGray);
        }
    }
}
