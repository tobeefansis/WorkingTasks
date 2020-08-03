using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    interface IEquipped 
    {
        public EquipType EquipType { get;  }
        public void ShowDescription();
    }
}
