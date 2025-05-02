using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Intresting_Books.Models;

namespace Personal_Library.Models
{
    public class SpecialBook : Book
    {
        public string Specification { get; set; } = "Unknown";

        public new string About() =>
           base.About() + $" Specification: {Specification}";
    }
}
