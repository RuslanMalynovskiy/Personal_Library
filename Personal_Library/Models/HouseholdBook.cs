using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal_Library.Models;

namespace Personal_Library.Models
{
    internal class HouseholdBook : Book
    {
        public string HouseholdType { get; set; } = "Unknown";

        public override string About() =>
           base.About() + $" Type of household: {HouseholdType}";
    }
}
