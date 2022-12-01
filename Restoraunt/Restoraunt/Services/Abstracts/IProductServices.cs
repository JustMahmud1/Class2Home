using Restoraunt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoraunt.Services.Abstracts
{
    internal interface IProductServices
    {
        public void CreateProduct(Product product);
        public void RemoveProduct();
        public void UpdateProduct();
        public Product GetAllInRestaurant();
        public void GetByIdRestaurant();

    }
}
