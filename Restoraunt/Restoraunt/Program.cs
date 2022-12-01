using Restoraunt.Models;
using Restoraunt.Services.Abstracts;
using Restoraunt.Services.Concretes;

namespace Restoraunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant(1 , "KFC");
            Product product = new Product("ChefBurger", 10, 1);
            IRestaurantService restaurantService = new RestaurantServices();
            IProductServices productServices = new ProductServices();
            restaurantService.CreateRestaurant(restaurant);
            productServices.CreateProduct(product);
            foreach (var item in restaurant.Products)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}