using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Iterator.Example
{
    interface IBookNumerable
    {
        IBookIterator CreateNumerator();
        int Count { get;}
        Book this[int index] { get; }
    }
}
