using System;

namespace MyAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();
            Console.WriteLine("----------------------------------------------");
            Horse horseOne = new Horse();
            driver.Drive(horseOne);

            Console.WriteLine("----------------------------------------------");
            FireBird fireBird = new FireBird();
            driver.SendMail(fireBird);

            Console.WriteLine("----------------------------------------------");
            BirdToTransportAdapter birdToTransport = new BirdToTransportAdapter(fireBird);
            driver.Drive(birdToTransport);



            //Unreal
            Console.WriteLine("----------------------------------------------");
            TransportToBirdAdapter transportToBird = new TransportToBirdAdapter(horseOne);
            driver.SendMail(transportToBird);

            Console.ReadLine();
        }
    }


    #region First interface
    public interface ITransport
    {
        public void Move();
    }

    public class Horse : ITransport
    {
        public void Move()
        {
            Console.WriteLine("Horse start move");
        }
    }
    #endregion



    #region Second interface
    public interface IBird
    {
        public void Fly();
    }

    public class FireBird : IBird
    {
        public void Fly()
        {
            Console.WriteLine("FireBird start Fly");
        }

    }

    #endregion


    #region Client
    public class Driver
    {
        public void Drive(ITransport transport)
        {
            Console.WriteLine("Driver move");
            transport.Move();
        }

        public void SendMail(IBird bird)
        {
            Console.WriteLine("Driver send mail");
            bird.Fly();
        }
    }
    #endregion

    #region Adpter Bird to transport
    class BirdToTransportAdapter : ITransport
    {
        IBird bird;
        public BirdToTransportAdapter(IBird b)
        {
            bird = b;
        }

        public void Move()
        {
            Console.WriteLine("Bird like transport");
            bird.Fly();
        }
    }
    #endregion


    #region Adpter Transport to bird
    class TransportToBirdAdapter : IBird
    {
        ITransport transport;
        public TransportToBirdAdapter(ITransport t)
        {
            transport = t;
        }

        public void Fly()
        {
            Console.WriteLine("Transport like Bird");
            transport.Move();
        }
    }
    #endregion
}
