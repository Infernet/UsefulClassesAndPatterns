using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Classes.StarWars.Gadgets
{
    class Grenade : AbstractGadgets
    {
        public override string Message()
        {
            return "Граната";
        }
    }
}
