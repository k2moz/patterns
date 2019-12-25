using MyAbstructFuctory.Factory;
using MyAbstructFuctory.Product;
using System;

namespace MyAbstructFuctory
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit unit1 = new Unit(new CheapUnitFactory()) { Name = "Oleg" };
            unit1.Move();
            unit1.Hit();

            Unit unit2 = new Unit(new ExpensiveUnitFactory()) { Name = "Maikl" };
            unit2.Move();
            unit2.Hit();

            Unit unit3 = new Unit(new MediumUnitFactory()) { Name = "Hoi" };
            unit3.Move();
            unit3.Hit();

            Console.ReadLine();
        }
    }
}
