using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.State.Example
{
    interface IWaterState
    {
        void Heat(Water water);
        void Frost(Water water);
    }
}
