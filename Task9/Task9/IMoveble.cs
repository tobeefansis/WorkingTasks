using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public interface IMoveble
    {
        int Speed { get; set; }
        void Move();
    }
}
