using System;

namespace Heyvanlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(1, "Husky" , "White");
            dog.GetKind();
            Dog dog1 = new Dog(2, "Shepherd" , "Orange");
            dog1.GetKind();
            
            Cat cat = new Cat(1, "Ragdoll", "White");
            cat.GetKind();
            Cat cat1 = new Cat(2, "British", "Yellow");
            cat1.GetKind();

            Fish fish = new Fish(1, "Salamon", "Grey");
            fish.GetKind();
            Fish fish1 = new Fish(2, "Golden", "Yellow");
            fish1.GetKind();



        }
    }
}
