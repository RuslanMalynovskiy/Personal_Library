using System;
using System.Collections.Generic;
using System.Linq;
using Personal_Library.Models;

namespace Personal_Library.Models
{
    public class Library
    {
        private readonly List<Book> books = new();

        public void Add(Book book)
        {
            if (book != null)
            {
                book.Id = books.Count + 1;
                books.Add(book);
            }
        }

        public bool Remove(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            return book != null && books.Remove(book);
        }

        public List<Book> Find(Func<Book, bool> predicate)
        {
            return books.Where(predicate).ToList();
        }

        public List<Book> GetAllBooks()
        {
            return books.ToList(); // копія списку
        }

        public Book? GetById(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }

        public int Count => books.Count;
    }
}

