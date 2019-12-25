using System;

namespace MyPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var unit1 = new Unit() { HP = 100 };
            var unit2 = unit1.Clone();
            unit1.HP = 50;

            Console.WriteLine(unit1.HP);
            Console.WriteLine((unit2 as Unit).HP);
            Console.ReadKey();
        }
    }
}
