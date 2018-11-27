using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Commands.Example
{
    class Microwave
    {
        public void StartCooking(int time)
        {
            Console.WriteLine("Подогреваем еду.");
            Task.Delay(time).GetAwaiter().GetResult();
        }
        public void StopCooking()
        {
            Console.WriteLine("Еда подогрета.");
        }
    }
}
