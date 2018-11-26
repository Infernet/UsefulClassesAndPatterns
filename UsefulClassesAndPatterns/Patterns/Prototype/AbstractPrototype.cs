using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Prototype
{
    abstract class AbstractPrototype
    {
        public int Id { get; set; }

        public AbstractPrototype(int id)
        {
            this.Id = id;
        }

        public abstract AbstractPrototype Clone();

    }
}
