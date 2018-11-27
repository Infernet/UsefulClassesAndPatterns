using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.State
{
    class Context
    {
        public AbstractState State { get; set; }
        public Context(AbstractState state)
        {
            this.State = state;
        }
        public void Request()
        {
            this.State.Handle(this);
        }

    }
}
