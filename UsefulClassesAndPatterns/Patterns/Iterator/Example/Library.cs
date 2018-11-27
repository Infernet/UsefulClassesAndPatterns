using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Iterator.Example
{
    class Library:IBookNumerable
    {
        private Book[] books;

        public Library()
        {
            books = new Book[]
            {
                new Book(){Name="Война и мир"},
                new Book(){Name="Отцы и дети"},
                new Book(){Name="Вишневый сад"}
            };
        }

        public Book this[int index]
        {
            get { return books[index]; }
        }

        public int Count
        {
            get { return books.Length; }
        }

        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }
    }
}
