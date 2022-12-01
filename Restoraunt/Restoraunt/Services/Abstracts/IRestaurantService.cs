using Restoraunt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoraunt.Services.Abstracts
{
    internal interface IRestaurantService
    {
        public void CreateRestaurant(Restaurant restaurant);
        public void RemoveRestaurant();
        public void UpdateRestaurant();
        public Restaurant GetAll();
        public void GetById();
    }
}
