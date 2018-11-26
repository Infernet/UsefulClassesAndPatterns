using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Strategy
{
    class Context
    {
        public IStrategy ContextStrategy { get; set; }

        public Context(IStrategy strategy)
        {
            ContextStrategy = strategy;
        }

        public void ExecuteAlgorythm()
        {
            ContextStrategy.Algorymth();
        }
    }
}
