using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assin1
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public Product(string name, double price, double quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double CalculateTotalCost()
        {
            return Price * Quantity;

        }

        public double CalculateTotalCost(double price, double quantity)
        {
            return price * quantity;
        }
    }
}
