using GroceryStore.Models;
using GroceryStore.Constants;

internal class Program 
{
    public static void Main(string[] args)
    {
        Store.AddCustomer("John", "Doe", 22, "M", true, 0.02);
        Store.AddCustomer("Sam", "Brooks", 67, "F", true, 0.12);
        Store.AddCustomer("Alois", "Winter", 15, "M", false);
        Store.AddCustomer("Ann", "Siemens", 44, "F", true, 0.09);
        Store.AddCustomer("Peter", "Parker", 9, "M", false);

        Store.AddProduct(new Drink("Coca-cola",1.12, 0.5, false));
        Store.AddProduct(new FruitsAndVegetables("Tomatoes", 0.99,0.5));
        Store.AddProduct(new Snacks("Lay’s Cheese",  2.49));
        Store.AddProduct(new Fish("Norway Herring", 4.55, ProductCategories.FishType.Ocean));
        Store.AddProduct(new Meat("Chicken Nuggets", 4.99));
        Store.AddProduct(new Drink("Aperol", 9.99, 0.75,true));

        Store.UpdateDiscountCard("Ann Siemens", false);
        Store.UpdateCustomerName("John Doe", "John", "Claus");

        Store.Customers[0].AddProductsToCart(Store.Products[0], 2);
        Store.Customers[0].AddProductsToCart(Store.Products[3], 1);
        Store.Customers[0].AddProductsToCart(Store.Products[1], 7);
        Store.Customers[2].AddProductsToCart(Store.Products[1], 3);
        Store.Customers[4].AddProductsToCart(Store.Products[2], 5);
        Store.Customers[4].AddProductsToCart(Store.Products[0], 2);
        Store.Customers[3].AddProductsToCart(Store.Products[5], 1);
        Store.Customers[1].AddProductsToCart(Store.Products[4], 1);

        Store.PrintCustomerInformation();

       
     

    }
}



