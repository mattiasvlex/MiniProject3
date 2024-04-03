﻿using System;
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

        public Phone(Office office, DateOnly date, int price, string? brand, string? model) : base(office, date, price)
        {
            Brand = brand;
            Model = model;
        }
    }
}
