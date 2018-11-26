using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Builder
{
    class Director
    {
        private AbstractBuilder Builder;

        public Director(AbstractBuilder builder)
        {
            this.Builder = builder;
        }

        public void Constructor()
        {
            Builder.BuildPartA();
            Builder.BuildPartB();
            Builder.BuildPartC();
        }

        public Product GetResult()
        {
            return Builder.GetResult();
        }
    }
}
