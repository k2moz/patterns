using System;
using System.Collections.Generic;
using System.Text;

namespace MyFactoryMethod
{
    public abstract class Guildhall
    {
        public abstract IUnit Create(string name);
    }
   
    public class HumanGuildhall : Guildhall
    {
        public override IUnit Create(string name)
        {
            return new HumanWorker() { Name = name };
        }
    }

    public class OrcGuildhall : Guildhall
    {
        public override IUnit Create(string name)
        {
            return new OrcWorker() { Name = name };
        }
    }
}
