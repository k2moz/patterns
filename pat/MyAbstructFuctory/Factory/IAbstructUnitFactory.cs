using MyAbstructFuctory.Products.Transport;
using MyAbstructFuctory.Products.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbstructFuctory.Factory
{
    public interface IAbstructUnitFactory
    {
        IAbstructWeapon CreateWeapon();
        IAbstructTransport CreateTransport();
    }
}
