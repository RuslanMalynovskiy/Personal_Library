using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal_Library.Models;

namespace Personal_Library.Models
{
    internal class HobbyBook : Book
    {
        public string HobbyType { get; set; } = "Unknown";
        public HobbyBook() => Type = "HobbyBook";
        public override string About() =>
       base.About() + $" Хобі: {HobbyType}";
    }
}
