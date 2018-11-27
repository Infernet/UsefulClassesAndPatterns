using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Iterator.Example
{
    interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
}
