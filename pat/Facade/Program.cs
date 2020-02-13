using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {

            SubsystemA a = new SubsystemA();
            SubsystemB b = new SubsystemB();
            SubsystemC c = new SubsystemC();

            Facade facade = new Facade(a, b, c);
            facade.Operation1();
            facade.Operation2();

            Console.ReadLine();
        }


    }

    public class SubsystemA
    {
        public void A1()
        { }
    }
    public class SubsystemB
    {
        public void B1()
        { }
    }
    public class SubsystemC
    {
        public void C1()
        { }
    }

    public class Facade
    {
        SubsystemA subsystemA;
        SubsystemB subsystemB;
        SubsystemC subsystemC;

        public Facade(SubsystemA sa, SubsystemB sb, SubsystemC sc)
        {
            subsystemA = sa;
            subsystemB = sb;
            subsystemC = sc;
        }
        public void Operation1()
        {
            subsystemA.A1();
            subsystemB.B1();
            subsystemC.C1();
        }
        public void Operation2()
        {
            subsystemB.B1();
            subsystemC.C1();
        }
    }

    class Client
    {
        public void Main()
        {
            Facade facade = new Facade(new SubsystemA(), new SubsystemB(), new SubsystemC());
            facade.Operation1();
            facade.Operation2();
        }
    }
}
