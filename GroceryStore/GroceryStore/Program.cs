﻿using GroceryStore.Models;
using GroceryStore.Constants;
using System.Text.Json;
using System.Text.Json.Serialization;
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
        Store.UpdateCustomerName("John Doe", "John", "Claus");



        Store.GetCustomer("John Claus").AddProductsToCart(Store.GetProduct("Coca-cola"), 2);
        Store.GetCustomer("John Claus").AddProductsToCart(Store.GetProduct("Norway Herring"), 1);
        Store.GetCustomer("John Claus").AddProductsToCart(Store.GetProduct("Tomatoes"), 7);
        Store.GetCustomer("Alois Winter").AddProductsToCart(Store.GetProduct("Tomatoes"), 3);
        Store.GetCustomer("Sam Brooks").AddProductsToCart(Store.GetProduct("Chicken Nuggets"), 1);
        Store.GetCustomer("Ann Siemens").AddProductsToCart(Store.GetProduct("Aperol"), 1);
        Store.GetCustomer("Peter Parker").AddProductsToCart(Store.GetProduct("Lay’s Cheese"), 5);
        Store.GetCustomer("Peter Parker").AddProductsToCart(Store.GetProduct("Coca-cola"), 2);
        Store.GetCustomer("Peter Parker").AddProductsToCart(Store.GetProduct("Aperol"), 1);

        
        Store.PrintCustomerInformation();



        var options = new JsonSerializerOptions()
        { IncludeFields = true,WriteIndented = true };
       
        string productsJson = JsonSerializer.Serialize(Store.Products, options);
        File.WriteAllText("products.json", productsJson);
        string customersJson = JsonSerializer.Serialize(Store.Customers, options);
        File.WriteAllText("customers.json", customersJson);



    }
}



