using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject3
{
    internal class Computer : Asset
    {
        public string? Brand {  get; set; }
        public string? Model { get; set; }
        public Computer(string? brand, string? model, string? office, string? date, int price, string? currency) : base(office, date, price, currency)
        {
            Brand = brand;
            Model = model;
        }
    }
}
