using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.State.Example
{
    class GasWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем пар в жидкость");
            water.State = new LiquidWaterState();
        }

        public void Heat(Water water)
        {
            Console.WriteLine("Повышаем температуру водяного пара");
        }
    }
}
