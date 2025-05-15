using System;
using System.Collections.Generic;
using Personal_Library.Models;
using Personal_Library.Forms;

namespace Personal_Library
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Library library = new Library();
            library.GenerateTestData(5);

            foreach (var book in library.GetAllBooks())
            {
                Console.WriteLine(book.About());
            }

            // ����� ���� �� �������
            var booksByAuthor = library.Find(b => b.Author.Contains("Author 1"));
            Console.WriteLine("\n����� ������ Author 1:");
            foreach (var book in booksByAuthor)
            {
                Console.WriteLine(book.About());
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
