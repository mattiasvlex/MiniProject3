using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject3
{
    internal class Phone : Asset
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }

        public Phone(string? brand, string? model, string? office, string? date, int price, string? currency) : base(office, date, price, currency)
        {
            Brand = brand;
            Model = model;
        }
    }
}
