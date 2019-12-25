using System;
using System.Collections.Generic;
using System.Text;
using MyAbstructFuctory.Products.Transport;
using MyAbstructFuctory.Products.Weapons;

namespace MyAbstructFuctory.Factory
{
    public class MediumUnitFactory : IAbstructUnitFactory
    {
        public IAbstructTransport CreateTransport()
        {
            return new Horse();
        }

        public IAbstructWeapon CreateWeapon()
        {
            return new Gun();
        }
    }
}
