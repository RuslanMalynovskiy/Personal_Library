using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal_Library.Models;

namespace Personal_Library.Models
{
    internal class FictionBook : Book
    {
        public string Genre { get; set; } = "Unknown";
        public FictionBook() => Type = "FictionBook";

        public override string About() =>
           base.About() + $" Жанр: {Genre}";
    }
}
