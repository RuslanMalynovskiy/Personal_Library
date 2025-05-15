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

        public void GenerateTestData(int count)
        {
            books.Clear();
            for (int i = 1; i <= count; i++)
            {
                if (i % 2 == 0)
                {
                    books.Add(new FictionBook
                    {
                        Id = i,
                        Title = $"Fiction {i}",
                        Author = $"Author {i}",
                        Publication = $"Publisher {i}",
                        Genre = "Fantasy"
                    });
                }
                else
                {
                    books.Add(new HobbyBook
                    {
                        Id = i,
                        Title = $"Hobby {i}",
                        Author = $"Author {i}",
                        Publication = $"Publisher {i}",
                        HobbyType = "Knitting"
                    });
                }
            }
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

