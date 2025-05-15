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
        public string BookStatus { get; set; } = "Unknown";
        public string Rating { get; set; } = "Unknown";

        public virtual string About() =>
           $"#{Id} '{Title}' by {Author} published by {Publication}";
    }
}
