using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Iterator
{
    class ConctreteAggregate : AbstractAggregate
    {
        private readonly ArrayList Items = new ArrayList();

        public override AbstractIterator CreateIterator()
        {
            return new ConctreteIterator(this);
        }

        public override object this[int index]{ get{ return Items[index]; } set { Items.Insert(index, value); } }

        public override int Count { get { return Items.Count; } set { } }

        
    }
}
