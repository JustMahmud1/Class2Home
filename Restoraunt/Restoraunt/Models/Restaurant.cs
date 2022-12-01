using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoraunt.Models
{
    internal class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Product[] Products = { };

        public Restaurant(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
