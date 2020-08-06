using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public interface IShoteble
    {
        Ammunition Ammunition { get; }
        void ChangeAmmunition(Ammunition ammo);
        void Shot();
    }
}
