using System;
using System.Collections.Generic;
using System.Text;

namespace MyBuilder.Builders
{
    public interface IUnitBuilder
    {
        void CreateTransport();
        void CreateWeapon();
        void CreateArmor();
    }
}
