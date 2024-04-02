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

        public Computer(Office office, DateTime date, int price, string? brand, string? model) : base(office, date, price)
        {
            Brand = brand;
            Model = model;
        }
    }
}
