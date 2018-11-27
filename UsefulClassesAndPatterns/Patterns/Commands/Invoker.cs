using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Commands
{
    class Invoker
    {
        private ACommand command;

        public void SetCommand(ACommand command)
        {
            this.command = command;
        }

        public void Run()
        {
            command.Execute();
        }

        public void Stop()
        {
            command.Undo();
        }
    }
}
