using GroceryStore.Models;
using GroceryStore.Constants;
using Newtonsoft.Json;
using GroceryStore.Core.Helpers;

internal class Program
{
    public static void Main(string[] args)
    {

        Store.AddCustomer("John", "Doe", 22, "M", true, 0.02);
        Store.AddCustomer("Sam", "Brooks", 67, "F", true, 0.12);
        Store.AddCustomer("Alois", "Winter", 15, "M", false);
        Store.AddCustomer("Ann", "Siemens", 44, "F", true, 0.09);
        Store.AddCustomer("Peter", "Parker", 9, "M", false);

        Store.AddProduct(new Drink("Coca-cola", 1.12, 0.5, false));
        Store.AddProduct(new FruitsAndVegetables("Tomatoes", 0.99, 0.5));
        Store.AddProduct(new Snacks("Lay’s Cheese", 2.49));
        Store.AddProduct(new Fish("Norway Herring", 4.55, FishType.Ocean));
        Store.AddProduct(new Meat("Chicken Nuggets", 4.99));
        Store.AddProduct(new Drink("Aperol", 9.99, 0.75, true));

        Store.UpdateDiscountCard("Ann Siemens", false);
        Store.UpdateCustomer("John Doe", "John", "Claus");

        Store.AddProductsToCart("John Claus", "Coca-cola", 2);
        Store.AddProductsToCart("John Claus", "Norway Herring", 1);
        Store.AddProductsToCart("John Claus", "Tomatoes", 7);
        Store.AddProductsToCart("Alois Winter", "Tomatoes", 3);
        Store.AddProductsToCart("Sam Brooks", "Chicken Nuggets", 1);
        Store.AddProductsToCart("Ann Siemens", "Aperol", 1);
        Store.AddProductsToCart("Peter Parker", "Lay’s Cheese", 5);
        Store.AddProductsToCart("Peter Parker", "Coca-cola", 2);
        Store.AddProductsToCart("Peter Parker", "Aperol", 1);

        Store.PrintCustomerInformation();

    





    }
}



