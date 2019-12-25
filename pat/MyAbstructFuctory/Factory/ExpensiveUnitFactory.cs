using System;
using System.Collections.Generic;
using System.Text;
using MyAbstructFuctory.Products.Transport;
using MyAbstructFuctory.Products.Weapons;

namespace MyAbstructFuctory.Factory
{
    public class ExpensiveUnitFactory : IAbstructUnitFactory
    {
        public IAbstructTransport CreateTransport()
        {
            return new Car();
        }

        public IAbstructWeapon CreateWeapon()
        {
            return new Gun();
        }
    }
}
