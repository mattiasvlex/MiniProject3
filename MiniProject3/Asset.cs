using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject3
{
    internal class Asset
    {
        public string? Office {  get; set; }
        public string? Date { get; set; }
        public int Price { get; set; }
        public string? Currency { get; set; }

        public Asset(string? office, string? date, int price, string? currency)
        {
            Office = office;
            Date = date;
            Price = price;
            Currency = currency;
        }

    }
}
