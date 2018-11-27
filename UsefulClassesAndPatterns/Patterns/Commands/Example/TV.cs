using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Commands.Example
{
    class TV
    {
        public void On()
        {
            Console.WriteLine("Телевизор включен.");
        }
        public void Off()
        {
            Console.WriteLine("Телевизор выключен.");
        }
    }
}
