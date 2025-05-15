using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Personal_Library.Models;

namespace Personal_Library.Models
{
    public class SpecialBook : Book
    {
        public string Specification { get; set; } = "Unknown";

        public override string About() =>
           base.About() + $" Specification: {Specification}";
    }
}
