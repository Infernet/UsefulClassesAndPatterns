﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulClassesAndPatterns.Classes.StarWars.Gadgets;
using UsefulClassesAndPatterns.Classes.StarWars.Weapons;

namespace UsefulClassesAndPatterns.Classes.StarWars.Solders
{
    /// <summary>
    /// Абстрактный класс солдата армии клонов
    /// </summary>
    abstract class AbstractSolder
    {
        public string UnitСode { get; private set; }
        public string Rank { get; private set; }
        protected AbstractWeapon Weapon;
        protected AbstractGadgets Gadgets;


        public AbstractSolder(string unitCode, string rank, AbstractWeapon gun, AbstractGadgets gadgets)
        {
            UnitСode = unitCode;
            Rank = rank;
            Weapon = gun;
            Gadgets = gadgets;
        }

        public virtual string Message()
        {
            return "Моё подразделение - " + UnitСode + Environment.NewLine +
                    "Звание - " + Rank + Environment.NewLine +
                    "Оружие - " + Weapon.Message() + Environment.NewLine +
                    "Гаджет - " + Gadgets.Message() + Environment.NewLine;
        }
        public string WhatIsWeapon()
        {
            return Weapon.Message();
        }

        public string WhatIsGadgets()
        {
            return Gadgets.Message();
        }
        public abstract string WhatIsSpecialty();
    }

}