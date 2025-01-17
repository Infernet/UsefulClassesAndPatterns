﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Iterator.Example
{
    class Reader
    {
        public void SeeBooks(Library library)
        {
            IBookIterator iterator = library.CreateNumerator();
            while(iterator.HasNext())
            {
                Book book = iterator.Next();
                Console.WriteLine(book.Name);
            }
        }
    }
}
