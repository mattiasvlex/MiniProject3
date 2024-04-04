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

        public Computer(string? brand, string? model, DateOnly date, int price, Office office) : base(date, price, office)
        {
            Brand = brand;
            Model = model;
        }
    }
}
