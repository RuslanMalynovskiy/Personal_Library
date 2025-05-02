using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intresting_Books.Models;

namespace Personal_Library.Models
{
    internal class HobbyBook : Book
    {
        public string HobbyType { get; set; } = "Unknown";

    public new string About() =>
       base.About() + $" Hobby: {HobbyType}";
    }
}
