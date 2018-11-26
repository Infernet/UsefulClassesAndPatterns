using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulClassesAndPatterns.Classes.StarWars.Solders;
using UsefulClassesAndPatterns.Classes.StarWars.Weapons;
using UsefulClassesAndPatterns.Classes.StarWars.Gadgets;

namespace UsefulClassesAndPatterns.Patterns.AbstractFactory
{
    class SniperFactory : AbstractFactory
    {
        public override AbstractSolder CreateSolder()
        {
            return new Sniper("Снайперский корпус", Random.Next(1, 1000), Ranks[Random.Next(0, Ranks.Count - 1)], new SniperRifle(), new Jetpack());
        }
    }
}
