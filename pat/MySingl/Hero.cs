using System;
using System.Collections.Generic;
using System.Text;

namespace MySingl
{
    public class Hero
    {
        private static Hero hero;
        private string _name;

        private  static readonly object _locker = new object();

        private Hero() { }
        private Hero(string name) { _name = name; }

        public static Hero getHero(string name)
        {
            if (hero == null)
            {
                lock (_locker)
                {
                    if (hero == null)
                        hero = new Hero(name);
                }
            }
            return hero;
        }

        public string Say()
        {
            return $"Hero - {_name}";
        }
    }
}
