using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Iterator
{
    abstract class AbstractAggregate
    {
        public abstract AbstractIterator CreateIterator();
        public abstract int Count { get; set; }
        public abstract object this[int index] { get;set; }
    }
}
