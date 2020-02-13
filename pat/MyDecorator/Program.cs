using System;

namespace MyDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Warior warior1 = new HumanWarrior("Oleg");
            warior1 = new OnionWarrior(warior1);
            Console.WriteLine(warior1.Name);
            Console.WriteLine($"Damage:{warior1.Attack()}");

            Console.WriteLine("_____________________");
            Warior warior2 = new HumanWarrior("Zul");
            warior2 = new SwordWarrior(warior2);
            Console.WriteLine(warior2.Name);
            Console.WriteLine($"Damage:{warior2.Attack()}");

            Console.WriteLine( "_____________________");
            Warior warior3 = new HumanWarrior("OlegZul");
            warior3 = new OnionWarrior(warior3);
            warior3 = new SwordWarrior(warior3);
            Console.WriteLine(warior3.Name);
            Console.WriteLine($"Damage:{warior3.Attack()}");

            Console.ReadLine();
        }
    }

    public abstract class Warior
    {
        public string Name { get; }
        public Warior(string name)
        {
            Name = name;
        }
        public abstract int Attack();
    }

    public class HumanWarrior : Warior
    {
        public HumanWarrior(string name) : base($"Human warrior {name}")
        {
            
        }
        public override int Attack()
        {
            return 10;
        }
    }

    public class OrcWarrior : Warior
    {
        public OrcWarrior(string name) : base($"Orc warrior {name}")
        {

        }

        public override int Attack()
        {
            return 8;
        }
    }


    public abstract class WarriorDecorator : Warior
    {
        protected Warior warior;
        public WarriorDecorator(string name, Warior warior):base(name)
        {
            this.warior = warior;
        }
    }


    public class OnionWarrior : WarriorDecorator
    {
        public OnionWarrior(Warior warior):base ($"{warior.Name}, with onion", warior)
        {

        }

        public override int Attack()
        {
            return warior.Attack() + 2;
        }
    }


    public class SwordWarrior : WarriorDecorator
    {
        public SwordWarrior(Warior warior) : base($"{warior.Name}, with sword", warior)
        {

        }

        public override int Attack()
        {
            return warior.Attack() + 1;
        }
    }
}
