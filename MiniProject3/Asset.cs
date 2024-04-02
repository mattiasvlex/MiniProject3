using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject3
{
    internal class Asset
    {
        public Office Office { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }

        public Asset(Office office, DateTime date, int price)
        {
            Office = office;
            Date = date;
            Price = price;
        }

    }
}
