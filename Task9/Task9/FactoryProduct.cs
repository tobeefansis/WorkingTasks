using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public abstract class FactoryProduct : ICloneable
    {
        public abstract object Clone();
    }
}
