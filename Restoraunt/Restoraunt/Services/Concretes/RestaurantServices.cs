using Restoraunt.Models;
using Restoraunt.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoraunt.Services.Concretes
{
    internal class RestaurantServices : IRestaurantService
    {

        public static Restaurant[] Restaurants = {};

        public void CreateRestaurant(Restaurant restaurant)
        {
            Array.Resize(ref Restaurants , Restaurants.Length+1);
            Restaurants[Restaurants.Length-1] = restaurant;
        }

        public Restaurant GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById()
        {
            throw new NotImplementedException();
        }

        public void RemoveRestaurant()
        {
            throw new NotImplementedException();
        }

        public void UpdateRestaurant()
        {
            throw new NotImplementedException();
        }
    }
}
