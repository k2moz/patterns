using System;
using System.Collections.Generic;
using System.Text;

namespace MyBuilder.Products
{
    public class Unit
    {
        public Transport Transport { get; set; }
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }
    }

    public class Armor { }
    public class Weapon { }
    public class Transport { }

    public class FlyTransport : Transport { }
}
