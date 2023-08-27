using GroceryStore.Models;
using GroceryStore.Constants;

public class Program
{
    public static void Main(string[] args)
    {
        Store store = new Store();

        store.AddCustomer("John", "Doe", 22, "M", true, 0.02);
        store.AddCustomer("Sam", "Brooks", 67, "F", true, 0.12);
        store.AddCustomer("Alois", "Winter", 15, "M", false);
        store.AddCustomer("Ann", "Siemens", 44, "F", true, 0.09);
        store.AddCustomer("Peter", "Parker", 9, "M", false);

        store.AddProduct("Coca-cola", ProductCategories.Category.Drinks, 1.12);
        store.AddProduct("Tomatoes", ProductCategories.Category.FruitsAndVegetables, 0.99);
        store.AddProduct("Lay’s Cheese", ProductCategories.Category.Snacks, 2.49);
        store.AddProduct("Norway Herring", ProductCategories.Category.Fish, 4.55);

        store.UpdateDiscountCard("Ann Siemens", false);
        store.UpdateCustomerName("John Doe", "John", "Claus");

        store.Customers[0].AddProductsToCart(store.Products[0], 2);
        store.Customers[0].AddProductsToCart(store.Products[3], 1);
        store.Customers[0].AddProductsToCart(store.Products[1], 7);
        store.Customers[2].AddProductsToCart(store.Products[1], 3);
        store.Customers[4].AddProductsToCart(store.Products[2], 5);
        store.Customers[4].AddProductsToCart(store.Products[0], 2);
        store.PrintCustomerInformation();
    }
}



