using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbstructFuctory.Products.Weapons
{
    public class Gun : IAbstructWeapon
    {
        public string Hit()
        {
            return "Shot";
        }
    }
}
