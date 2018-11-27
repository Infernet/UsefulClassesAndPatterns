using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Iterator
{
    class Program
    {
        void Main()
        {
            AbstractAggregate aggregate = new ConctreteAggregate();
            AbstractIterator iterator = aggregate.CreateIterator();

            object item = iterator.First();
            while(!iterator.IsDone())
            {
                item = iterator.Next();
            }
        }
    }
}
