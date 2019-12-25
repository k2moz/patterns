using MyBuilder.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBuilder.Builders
{
    public class ElfUnitBuilder : HumanUnitBuilder
    {
        new public void CreateTransport()
        {
            _unit.Transport = new FlyTransport();
        }
    }
}
