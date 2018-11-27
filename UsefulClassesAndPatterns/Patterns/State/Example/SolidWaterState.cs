using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.State.Example
{
    class SolidWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("Продолжаем заморозку льда");
            
        }

        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем лед в жидкость");
            water.State = new LiquidWaterState();
        }
    }
}
