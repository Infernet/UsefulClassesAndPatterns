using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.State.Example
{
    class Water
    {
        public IWaterState State { get; set; }

        public Water(IWaterState state)
        {
            this.State = state;
        }

        public void Heat()
        {
            State.Heat(this);
        }
        public void Frost()
        {
            State.Frost(this);
        }

    }
}
