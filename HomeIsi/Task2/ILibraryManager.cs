using System;
using System.Collections.Generic;
using System.Text;

namespace HomeIsi.Task2
{
    internal interface ILibraryManager
    {
       List<Book> Book { get; }

        void AddBook(Book book);
        Book ShowInfo(string bookname);
        List<Book> Search(Predicate<Book> predicate);
        List<Book> Filter(string genre);


    }
}
