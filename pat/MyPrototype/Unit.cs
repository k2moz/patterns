using System;
using System.Collections.Generic;
using System.Text;

namespace MyPrototype
{
    public class Unit : IClone
    {
        public int HP { get; set; }
        public IClone Clone()
        {
            return new Unit() { HP = HP };
        }
    }
}
