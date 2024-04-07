using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject3
{
    internal class Office
    {
        public string Country { get; set; }
        public string Currency { get; set; }
        public decimal ToLocal { get; set; }

        public Office(string country, string currency, decimal toLocal)
        {
            Country = country;
            Currency = currency;
            ToLocal = toLocal;
        }
    }
}
