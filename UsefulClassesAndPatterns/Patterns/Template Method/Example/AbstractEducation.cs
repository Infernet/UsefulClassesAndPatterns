using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Template_Method.Example
{
    abstract class AbstractEducation
    {
        public void Learn()
        {
            Enther();
            Study();
            PassExam();
            GetDocument();
        }
        public abstract void Enther();
        public abstract void Study();
        public virtual void PassExam()
        {
            Console.WriteLine("Сдаем выпускные экзамены");
        }
        public abstract void GetDocument();
    }
}
