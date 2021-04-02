using System;
using System.Collections.Generic;

namespace CarsFactoryMethod
{
    class Program
    {

        #region Product
        public abstract class Mechanic
        {
            public void Fo3() { Console.WriteLine("Fo Main"); }
        }

        public abstract class Car : Mechanic
        {
            public string Name { get; set; }
            public abstract void Drive();

            public virtual void Fo() { Console.WriteLine("Fo"); }
            public void Fo3() { Console.WriteLine("Fo3"); }
        }

        public class VAZ : Car
        {
            public override void Drive()
            {
                Console.WriteLine("Foo");
            }
        }

        public class BMW : Car
        {
            public override void Drive()
            {
                Console.WriteLine("Cool");
            }

            public override void Fo() { Console.WriteLine("BMW Fo"); }
            public void Fo3() { Console.WriteLine("BMW Fo 3"); }
        }

        public class MRC : Car
        {
            public override void Drive()
            {
                Console.WriteLine("Expensive");
            }
        }

        #endregion


        #region Creater
        public abstract class CarCreater
        {
            public abstract Car CreateCar();
         
        }

        public class VAZCreater : CarCreater
        {
            public override Car CreateCar()
            {
                return new VAZ();
            }
        }

        public class BMWCreater : CarCreater
        {
            public override Car CreateCar()
            {
                return new BMW();
            }
           
        }

        public class MercCreater : CarCreater
        {
            public override Car CreateCar()
            {
                return new MRC() { Name = "EEEbat" };
            }
        }
        #endregion


        public static void  ClientCode(CarCreater carCreater) {
            var car = carCreater.CreateCar();
            car.Drive();
        }




        static void Main(string[] args)
        {
            var bmw = new BMW();
            bmw.Fo();
            bmw.Fo3();

            var car = (Car)bmw;
            car.Fo();
            car.Fo3();

            var mech = (Mechanic)bmw;
            //car.Fo();
            mech.Fo3();

            //var car = new Car();
            //List<Car> cars = new List<Car>();

            //var vaz2110 = new VAZ();
            //var bmwi7 = new BMW();
            ////var mercSLK = new MRC() { Name="HOI"};

            //cars.Add(vaz2110);
            //cars.Add(bmwi7);

            //CarCreater creater = new VAZCreater();

            //var vaz2120 = creater.CreateCar();
            //var var2123 = creater.CreateCar();

            //creater = new BMWCreater();

            //var bmw3 = creater.CreateCar();


            //creater = new MercCreater();
            //var mercSLS = creater.CreateCar();

            //cars.Add(bmw3);
            //cars.Add(mercSLS);

            //foreach (var car in cars)
            //{
            //    car.Drive();
            //}

            //ClientCode(new BMWCreater());

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
