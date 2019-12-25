using System;

namespace pat
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new ConcreteFactory1());
            client.Run();
        }
    }

    //class Unit
    //{
    //    public int Id { get; set; }
    //}

    //class Worker : Unit
    //{
    //    public bool IsWorked { get; set; }
    //    public void CreateBuilding() { }
    //}



    //public interface IWork
    //{
    //    void DoWork();
    //}
    //public class Worker : IWork
    //{
    //    public void DoWork()
    //    {
    //        Console.WriteLine("Do Work");
    //    }
    //}

    //class Race
    //{

    //}
    //class Unit
    //{
    //    public Race Race { get; set; }
    //}

    //public class Tool
    //{ }

    //public class Worker
    //{
    //    Tool tool;
    //    public Worker(Tool tool)
    //    {
    //        this.tool = tool;
    //    }
    //}

    //abstract class Product
    //{ }

    //class ConcreteProductA : Product
    //{ }

    //class ConcreteProductB : Product
    //{ }

    //abstract class Creator
    //{
    //    public abstract Product FactoryMethod();
    //}

    //class ConcreteCreatorA : Creator
    //{
    //    public override Product FactoryMethod() { return new ConcreteProductA(); }
    //}

    //class ConcreteCreatorB : Creator
    //{
    //    public override Product FactoryMethod() { return new ConcreteProductB(); }
    //}


    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    abstract class AbstractProductA
    { }

    abstract class AbstractProductB
    { }

    class ProductA1 : AbstractProductA
    { }

    class ProductB1 : AbstractProductB
    { }

    class ProductA2 : AbstractProductA
    { }

    class ProductB2 : AbstractProductB
    { }

    class Client
    {
        private AbstractProductA abstractProductA;
        private AbstractProductB abstractProductB;

        public Client(AbstractFactory factory)
        {
            abstractProductB = factory.CreateProductB();
            abstractProductA = factory.CreateProductA();
        }
        public void Run()
        { }
    }
}
