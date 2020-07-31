using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    public interface IItem
    {
        bool Reusable { get; }
        abstract void Use(Monster monster);
    }
}
