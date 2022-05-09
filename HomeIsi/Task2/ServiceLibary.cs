using System;
using System.Collections.Generic;
using System.Text;

namespace HomeIsi.Task2
{
    internal class ServiceLibary : ILibraryManager
    {
        public List<Book> Books;
        public List<Book> Book => Books;

        public void AddBook(Book book)
        {
           List<Book> books = new List<Book>();
            foreach (Book b in Books)
            {
                if (b.Name.ToUpper() != book.Name.ToUpper())
                {
                    books.Add(book);
                }
                
            }
            throw new Exception("SameBookalreadyAddedExpection");

        }

        public List<Book> Filter(string genre)
        {
            List<Book> books = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Genre.ToLower() == genre.ToLower())
                {
                    books.Add(book);
                }
            }
            return books;

        }

        public List<Book> Search(Predicate<Book> predicate)
        {
            List<Book> books = new List<Book>();
            foreach (Book book in Books)
            {
                if (predicate(book))
                {
                    books.Add(book);
                }
            }
            return books;

        }

        public Book ShowInfo(string bookname)
        {
           foreach (Book book in Books)
            {
                if (book.Name.ToLower() == bookname.ToLower())
                    return book;
            }
            throw new Exception("BookNotFoundException");
        }
    }
}
