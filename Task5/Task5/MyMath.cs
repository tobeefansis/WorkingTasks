using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    public static class MyMath
    {
        public static int Sum(params int[] values)
        {
            return values.Sum(n => n);
        }

        public static float Sum(params float[] values)
        {
            return values.Sum(n => n);
        }

        public static decimal Sum(params decimal[] values)
        {
            return values.Sum(n => n);
        }

        public static double Sum(params double[] values)
        {
            return values.Sum(n => n);
        }

        public static float Division(int first, float second)
        {
            return first / second;
        }

        public static decimal Factorial(int value)
        {
            int sum = 1;
            for (int i = 1; i <= value; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
