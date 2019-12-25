using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbstructFuctory.Products.Weapons
{
    public class Sword : IAbstructWeapon
    {
        public string Hit()
        {
            return "Cut";
        }
    }
}
