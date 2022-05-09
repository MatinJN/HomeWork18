using System;
using System.Collections.Generic;
using System.Text;

namespace HomeIsi.Models
{
    internal class Libary
    {
        List<Book> Books { get; set; }

        public Libary()
        {
            Books = new List<Book>();
        }

        public List<Book> FindAllBooksByName(string name)
        {
            List<Book> book = Books.FindAll(b => b.Name.ToLower().Contains(name));
            {
                foreach (Book b in book)
                {
                    Console.WriteLine(b);
                }
            }
            return book;
        }

        public void RemoveAllBookByName(string name)
        {
            List<Book> book = new List<Book>();

            foreach (Book b in Books)
            {
                if(b.Name.ToLower() == name.ToLower())
                {
                    book.Remove(b);
                }
            }         
        }

        public List<Book> SearchBooks(string name)
        {
            List<Book> book = Books.FindAll(b => b.Name.ToLower().Contains(name) || b.Code.ToLower().Contains(name) || b.AuthorName.ToLower().Contains(name));
            {
                foreach (Book b in book)
                {
                    Console.WriteLine(b);
                }
            }
            return Books;
        }

        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            List<Book> book = new List<Book>();
            foreach(Book b in Books)
            {
                if (book.Count > min && book.Count < max)
                {
                    book.Add(b);
                }
            }
            return Books;
        }
        public void RemoveByNo(string name)
        {
            List<Book> book = new List<Book>();

            foreach (Book b in Books)
            {
                if (b.Code.ToLower() == name.ToLower())
                {
                    book.Remove(b);
                }
            }
        }

    }
}
