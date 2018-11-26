using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Builder
{
    class ConctreteBuilder : AbstractBuilder
    {
        public ConctreteBuilder()
            : base()
        {

        }

        public override void BuildPartA()
        {
            Product.Add("Part A");
        }

        public override void BuildPartB()
        {
            Product.Add("Part B");
        }

        public override void BuildPartC()
        {
            Product.Add("Part C");
        }
    }
}
