using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Personal_Library.Models
{
    public class Library
    {
        private readonly List<Book> books = new();
        public int Count => books.Count;

        public Book? GetById(int id) => books.FirstOrDefault(b => b.Id == id);

        public void Add(Book book)
        {
            if (book == null) return;

            if (book.Id <= 0 || books.Any(b => b.Id == book.Id))
            {
                book.Id = books.Count == 0 ? 1 : books.Max(b => b.Id) + 1;
            }

            books.Add(book);
        }

        public bool Remove(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            return book != null && books.Remove(book);
        }

        public List<Book> GetAllBooks() => books.ToList();

        public void Clear() => books.Clear();

        public static void SaveToFile(string filePath, List<Book> books)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IncludeFields = true,
                PropertyNameCaseInsensitive = true
            };

            var typedObjects = books.Select(book => (object)book).ToList();
            string json = JsonSerializer.Serialize(typedObjects, options);
            File.WriteAllText(filePath, json);
        }

        public static List<Book>? LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath)) return null;

            var json = File.ReadAllText(filePath);
            var rawBooks = JsonSerializer.Deserialize<List<JsonElement>>(json, new JsonSerializerOptions
            {
                IncludeFields = true,
                PropertyNameCaseInsensitive = true
            });

            if (rawBooks == null) return null;

            var typedBooks = new List<Book>();

            foreach (var element in rawBooks)
            {
                string type = element.GetProperty("Type").GetString() ?? "";

                Book? book = type switch
                {
                    "FictionBook" => JsonSerializer.Deserialize<FictionBook>(element.GetRawText()),
                    "HobbyBook" => JsonSerializer.Deserialize<HobbyBook>(element.GetRawText()),
                    "HouseholdBook" => JsonSerializer.Deserialize<HouseholdBook>(element.GetRawText()),
                    "SpecialBook" => JsonSerializer.Deserialize<SpecialBook>(element.GetRawText()),
                    "OtherBook" => JsonSerializer.Deserialize<OtherBook>(element.GetRawText()),
                    _ => JsonSerializer.Deserialize<Book>(element.GetRawText())
                };

                if (book != null)
                {
                    typedBooks.Add(book);
                }
            }

            return typedBooks;
        }
    }
}
