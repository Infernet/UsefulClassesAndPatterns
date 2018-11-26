using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Builder
{
    abstract class AbstractBuilder
    {
        protected Product Product;

        public AbstractBuilder()
        {
            Product = new Product();
        }

        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();
        public Product GetResult()
        {
            return Product;
        }
    }
}
