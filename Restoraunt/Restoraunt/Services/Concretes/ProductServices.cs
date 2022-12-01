using Restoraunt.Models;
using Restoraunt.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoraunt.Services.Concretes
{
    internal class ProductServices : IProductServices
    {
        public void CreateProduct(Product product)
        {
            foreach (var item in RestaurantServices.Restaurants)
            {
                if(item.Name == "KFC")
                {
                    Array.Resize(ref item.Products, item.Products.Length + 1);
                    item.Products[item.Products.Length - 1] = product;
                }
            }
        }

        public Product GetAllInRestaurant()
        {
            throw new NotImplementedException();
        }

        public void GetByIdRestaurant()
        {

        }

        public void RemoveProduct()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct()
        {
            throw new NotImplementedException();
        }
    }
}
