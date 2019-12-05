using System;
using System.Collections.Generic;
using System.Text;

namespace AbstructFactory.Factories
{
    // Каждая Конкретная Фабрика имеет соответствующую вариацию продукта.
    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
