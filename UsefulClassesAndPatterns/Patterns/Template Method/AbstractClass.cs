using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Template_Method
{
    abstract class AbstractClass
    {
        public AbstractClass() { }

        public abstract void Operation1();
        public abstract void Operation2();

        public void TemplateMethod()
        {
            Operation1();
            Operation2();
        }
    }
}
