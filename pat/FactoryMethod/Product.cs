using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    // Интерфейс Продукта объявляет операции, которые должны выполнять все
    // конкретные продукты.
    public interface IProduct
    {
        string DoSomethink();
        // this is comment
    }

    // Конкретные Продукты предоставляют различные реализации интерфейса
    // Продукта.
    class ConcreteProduct1 : IProduct
    {
        public string DoSomethink()
        {
            return "{Result of ConcreteProduct1}";
        }
    }

    class ConcreteProduct2 : IProduct
    {
        public string DoSomethink()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
