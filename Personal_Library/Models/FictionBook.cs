using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intresting_Books.Models;

namespace Personal_Library.Models
{
    internal class FictionBook : Book
    {
        public string Genre { get; set; } = "Unknown";

        public new string About() =>
           base.About() + $" Genre: {Genre}";
    }
}
