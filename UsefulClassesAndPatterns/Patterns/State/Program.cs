using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.State
{
    class Program
    {
        public void Main()
        {
            Context context = new Context(new StateA());
            context.Request();//Переход в состояние Б
            context.Request();//Переход в состояние А


        }
    }
}
