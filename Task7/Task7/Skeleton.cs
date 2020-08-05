using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Skeleton
    {
        static int lastID;
        public int id;
        public Action<int> OnDeath;
        public Skeleton()
        {
            id = ++lastID;
        }
        public void Kill()
        {
            OnDeath?.Invoke(id);
        }
    }
    public class Observer
    {
        public static void AddListener(int t)
        {
            Console.WriteLine(t);
        }
    }
}
