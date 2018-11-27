using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Commands.Example
{
    class MicrowaveOnCommand : ICommand
    {
        private Microwave microwave;
        int time;

        public MicrowaveOnCommand(Microwave microwave,int time)
        {
            this.microwave = microwave;
            this.time = time;
        }

        public void Execute()
        {
            microwave.StartCooking(time);
            microwave.StopCooking();
        }

        public void Undo()
        {
            microwave.StopCooking();
        }
    }
}
