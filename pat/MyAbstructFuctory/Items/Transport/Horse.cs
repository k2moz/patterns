using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbstructFuctory.Products.Transport
{
    public class Horse : IAbstructTransport
    {
        public string Move()
        {
            return "Move on Horse";
        }
    }
}
