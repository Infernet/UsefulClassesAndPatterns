using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.State
{
    class StateB : AbstractState
    {

        public override void Handle(Context context)
        {
            context.State = new StateA();
        }
    }
}
