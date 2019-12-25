using MyAbstructFuctory.Factory;
using MyAbstructFuctory.Products.Transport;
using MyAbstructFuctory.Products.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbstructFuctory.Product
{
    public class Unit
    {
        IAbstructWeapon _abstructWeapon;
        IAbstructTransport _abstructTransport;

        public string Name { get; set; }
        public Unit(IAbstructUnitFactory abstructFactory)
        {
            _abstructWeapon = abstructFactory.CreateWeapon();
            _abstructTransport = abstructFactory.CreateTransport();
        }

        public void Move()
        {
            Console.WriteLine($"{Name} {_abstructTransport.Move()}");
        }

        public void Hit()
        {
            Console.WriteLine($"{Name} {_abstructWeapon.Hit()}");
        }
    }
}
