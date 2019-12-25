using System;

namespace MySingl
{
    class Program
    {
        static void Main(string[] args)
        {
            var hero1 = Hero.getHero("Lich King");
            var hero2 = Hero.getHero("Artas");

           

            Console.WriteLine(hero1.Say());
            Console.WriteLine(hero2.Say());

            Console.ReadLine();
        }
    }
}
