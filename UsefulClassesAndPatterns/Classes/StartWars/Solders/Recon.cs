using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulClassesAndPatterns.Classes.StarWars.Gadgets;
using UsefulClassesAndPatterns.Classes.StarWars.Weapons;

namespace UsefulClassesAndPatterns.Classes.StarWars.Solders
{
    class Recon:AbstractSolder
    {
        private string Eavesdropping;


        public Recon(string unitCode, int number, string rank, AbstractWeapon gun, AbstractGadgets gadgets)
    : base(unitCode + " №" + number.ToString(), rank, gun,gadgets)
        {
            Eavesdropping = "Скрытность";
        }

        public override string Message()
        {
            return base.Message()+ "Особенность - " + Eavesdropping + Environment.NewLine;
        }

        public override string WhatIsSpecialty()
        {
            return Eavesdropping;
        }
    }
}
