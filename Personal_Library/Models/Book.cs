using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal_Library.Models;

namespace Personal_Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = "Unknown";
        public string Author { get; set; } = "Unknown";
        public string Publication { get; set; } = "Unknown";
        public string Availability { get; set; } = "Unknown";
        public string Type { get; set; } = "Book";
        public int Rating { get; set; } = 0;
        public virtual string About() =>
           $"#{Id} '{Title}' за авторством {Author}, за видавництвом {Publication}, Наявність: {Availability}, Оцінка: {Rating}/5";
    }
}
