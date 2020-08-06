using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public class Factory
    {
        public Blueprint Blueprint { get; private set; }

        public void ChangeBlueprint(Blueprint blueprint)
        {
            Blueprint = blueprint;
        }

        public FactoryProduct CreateCopy(FactoryProduct original)
        {
            return (FactoryProduct)original.Clone();
        }

        public Factory(Blueprint blueprint)
        {
            Blueprint = blueprint;
        }

        public FactoryProduct Build()
        {
            return Blueprint.Create();
        }
    }
}
