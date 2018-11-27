using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Commands
{
    abstract class ACommand
    {
        public abstract void Execute();
        public abstract void Undo();
    }
}
