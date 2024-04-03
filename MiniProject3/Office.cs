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
        public string Currency {  get; set; }
        public decimal ToUSD { get; set; }

        public Office(string country, string currency, decimal toUSD)
        {
            Country = country;
            Currency = currency;
            ToUSD = toUSD;
        }
    }
}
