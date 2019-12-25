using MyBuilder.Barracks;
using MyBuilder.Builders;
using System;

namespace MyBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanUnitBuilder humanBuilder = new HumanUnitBuilder();
            humanBuilder.CreateArmor();
            humanBuilder.CreateTransport();
            humanBuilder.CreateWeapon();

            var humanUnit1 = humanBuilder.GetUnit();
            
            ElfUnitBuilder elfBuilder = new ElfUnitBuilder();
            elfBuilder.CreateArmor();
            elfBuilder.CreateTransport();
            elfBuilder.CreateWeapon();

            var elfUnit1 = elfBuilder.GetUnit();

            HumanBarack humanBarack1 = new HumanBarack();
            var humanUnit2 = humanBarack1.CreateHumanUnit(humanBuilder);

        }
    }
}
