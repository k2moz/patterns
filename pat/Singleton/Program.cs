using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello singleton Sample!");

            #region 1. Simple singleton Test
            //var simpleSingleton1 = SimpleSoingleton.GetInstance("01");
            //var simpleSingleton2 = SimpleSoingleton.GetInstance("02");
            #endregion


            #region 2. Siple Singlton with multitask error
            List<Task> tasks = new List<Task>();
            for (var i = 0; i < 10; i++)
            {
                var task = new Task(() => { var _inst = SimpleSoingleton.GetInstance(i.ToString()); Console.WriteLine(_inst.Value); });
                tasks.Add(task);
                task.Start();
            }

            Task.WhenAll(tasks);
            #region

            #region 3. Concurente Singleton
            List<Task> tasks2 = new List<Task>();
            for (var i = 0; i < 10; i++)
            {
                var task = new Task(() => { var _inst = ConcurenteSingleton.GetInstance(i.ToString()); Console.WriteLine(_inst.Value); });
                tasks2.Add(task);
                task.Start();
            }
            Task.WhenAll(tasks2);
            #endregion

            Console.ReadKey();
        }
    }
}
