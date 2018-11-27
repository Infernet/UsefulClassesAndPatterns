using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Prototype
{
    class ConcretePrototypeB : AbstractPrototype
    {
        public ConcretePrototypeB(int id)
            : base(id)
        {

        }

        public override AbstractPrototype Clone()
        {
            return new ConcretePrototypeB(this.Id);
        }
    }
}
