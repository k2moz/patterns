using MyBuilder.Builders;
using MyBuilder.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBuilder.Barracks
{
    public class HumanBarack
    {
        public Unit CreateHumanUnit(HumanUnitBuilder builder)
        {
            builder.CreateArmor();
            builder.CreateTransport();
            builder.CreateWeapon();
            return builder.GetUnit();
        }
    }
}
