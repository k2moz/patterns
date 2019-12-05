using System;
using System.Collections.Generic;
using System.Text;

namespace AbstructFactory
{
    // Каждый отдельный продукт семейства продуктов должен иметь базовый
    // интерфейс. Все вариации продукта должны реализовывать этот интерфейс.
    public interface IAbstractProductA
    {
        string UsefulFunctionA();
    }
}
