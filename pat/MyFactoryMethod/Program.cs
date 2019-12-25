using System;

namespace MyFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Guildhall guildhall = new HumanGuildhall();
            IUnit worker1 = guildhall.Create("Oleg");

            guildhall = new OrcGuildhall();
            IUnit worker2 = guildhall.Create("Zull");

            Console.WriteLine(worker1.DoSomethink());
            Console.WriteLine(worker2.DoSomethink());

            Console.ReadLine();
        }
    }
}
