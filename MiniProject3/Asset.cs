using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject3
{
    internal class Asset
    {
        private int _price;

        public int Price {

            get => _price;

            set
            {
                if (value < 0)
                {
                    _price = 0;
                }
                else
                {
                    _price = value;
                }
            }
         
        }
        public DateOnly Date { get; set; }
        public Office Office { get; set; }

        public Asset(DateOnly date, int price, Office office)
        {
            Date = date;
            Price = price;
            Office = office;
        }
        protected decimal ToLocal()
        {
            return this.Price * this.Office.ToLocal;
        }
    }
}
