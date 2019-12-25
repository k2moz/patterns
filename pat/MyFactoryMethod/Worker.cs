using System;
using System.Collections.Generic;
using System.Text;

namespace MyFactoryMethod
{

    public interface IUnit
    {
        string Name { get; set; }
        string DoSomethink();
    }


    class HumanWorker : IUnit
    {
        public string Name { get; set; }
        public string DoSomethink()
        {
            return $"{Name} say: I am ready";
        }
    }

    class OrcWorker : IUnit
    {
        public string Name { get; set; }
        public string DoSomethink()
        {
            return $"{Name} say: Uhhu";
        }
    }

}
