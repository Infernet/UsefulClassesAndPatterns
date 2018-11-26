using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulClassesAndPatterns.Classes.StarWars.Gadgets;
using UsefulClassesAndPatterns.Classes.StarWars.Weapons;

namespace UsefulClassesAndPatterns.Classes.StarWars.Solders
{
    class Sniper: AbstractSolder
    {
        private string Camouflage;

        public Sniper(string unitCode,int number, string rank, AbstractWeapon gun, AbstractGadgets gadgets)
    : base(unitCode+" №"+number.ToString(), rank, gun,gadgets)
        {
            Camouflage = "Маскировочный камуфляж";
        }

        public override string Message()
        {
            return base.Message() + "Особенность - " + Camouflage + Environment.NewLine;
        }

        public override string WhatIsSpecialty()
        {
            return Camouflage;
        }
    }
}
