using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    public class Random
    {
        static System.Random _random = new System.Random();
        public static int Range(int value, int range)
        {
            return _random.Next(value - range / 2, value + range / 2);

        }
        public static int Next(int min, int max) => _random.Next(min, max);
    }
}
