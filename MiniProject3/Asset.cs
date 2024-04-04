using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject3
{
    internal class Asset
    {
        public DateOnly Date { get; set; }
        public int Price { get; set; }
        public Office Office { get; set; }

        public Asset(DateOnly date, int price, Office office)
        {
            Date = date;
            Price = price;
            Office = office;
        }

    }
}
