using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoraunt.Models
{
    internal class Product
    {
        public static int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPrice { get; set; }
        public Product(string name, double price, double discountprice)
        {
            Id++;
            Name = name;
            Price = price;
            DiscountPrice = Price * ((100-discountprice) / 100);
        }
    }
}
