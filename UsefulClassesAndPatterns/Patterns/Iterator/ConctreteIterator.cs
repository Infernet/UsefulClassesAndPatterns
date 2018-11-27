using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Iterator
{
    class ConctreteIterator : AbstractIterator
    {
        private readonly AbstractAggregate aggregate;
        private int current;
        
        public ConctreteIterator(AbstractAggregate aggregate) { this.aggregate = aggregate; }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count;
        }

        public override object Next()
        {
            object ret = null;
            current++;
            if(current< aggregate.Count)
            {
                ret = aggregate[current];
            }
            return ret;
        }
    }
}
