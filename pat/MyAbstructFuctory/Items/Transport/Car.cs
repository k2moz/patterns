using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbstructFuctory.Products.Transport
{
    public class Car : IAbstructTransport
    {
        public string Move()
        {
            return "Drive a car";
        }
    }
}
