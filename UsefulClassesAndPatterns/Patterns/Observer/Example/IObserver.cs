using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Observer.Example
{
    interface IObserver
    {
        void Update(Object obj);
    }
}
