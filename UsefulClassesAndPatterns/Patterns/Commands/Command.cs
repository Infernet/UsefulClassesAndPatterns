using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Commands
{
    class Command : ACommand
    {
        private Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public override void Execute()
        {
            receiver.Operation();
        }

        public override void Undo()
        {
            
        }
    }
}
