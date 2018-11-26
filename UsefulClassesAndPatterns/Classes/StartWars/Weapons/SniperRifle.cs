using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Classes.StarWars.Weapons
{
    class SniperRifle : AbstractWeapon
    {
        public override string Message()
        {
            return "Снайперская винтовка";
        }
    }
}
