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

        public Phone(string? brand, string? model, DateOnly date, int price, Office office) : base(date, price, office)
        {
            Brand = brand;
            Model = model;
        }
    }
}
