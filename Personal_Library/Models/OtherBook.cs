using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal_Library.Models;

namespace Personal_Library.Models
{
    internal class OtherBook : Book
    {
        public string BookType { get; set; } = "Unknown";
        public OtherBook() => Type = "OtherBook";
        public override string About() =>
           base.About() + $" Тип книги: {BookType}";
    }
}
