using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject3
{
    internal class Computer : Asset
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Computer(string brand, string model, DateOnly date, int price, Office office) : base(date, price, office)
        {
            Brand = brand;
            Model = model;
        }

        public override string ToString()
        {
            return this.GetType().Name.PadRight(14) + this.Brand.PadRight(15) + this.Model.PadRight(15) + this.Office.Country.PadRight(15) 
                + this.Date.ToString().PadRight(15) + this.Price.ToString().PadRight(15) + this.Office.Currency.PadRight(15) + ToLocal();
        }
    }
}
