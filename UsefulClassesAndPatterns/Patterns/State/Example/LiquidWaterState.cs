using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.State.Example
{
    class LiquidWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем жидность в лед");
            water.State = new SolidWaterState();
        }

        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем жидность в пар");
            water.State = new GasWaterState();
        }
    }
}
