using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Commands.Example
{
    class Client
    {
        void Main()
        {
            Pult pult = new Pult();
            TV tv = new TV();
            TVOnCommand command = new TVOnCommand(tv);

            pult.SetCommand(command);

            pult.PressButton();
            pult.PressUndo();

            Microwave microwave = new Microwave();
            MicrowaveOnCommand microwaveCommand = new MicrowaveOnCommand(microwave,5000);

            pult.SetCommand(microwaveCommand);

            pult.PressButton();


        }
    }
}
