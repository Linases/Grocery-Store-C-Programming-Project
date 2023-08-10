using GroceryStore.Models;
using GroceryStore.Constants;

public class Program
{
    public static void Main(string[] args)
    {

        //Customer c1 = new Customer("John", "Doe", 22, "M", true, 0.02);
        //Customer c2 = new Customer("Sam", "Brooks", 67, "F", true, 0.12);
        //Customer c3 = new Customer("Alois", "Winter", 15, "M", false, 0);
        //Customer c4 = new Customer("Ann", "Siememns", 44, "F", true, 0.09);
        //Customer c5 = new Customer("Peter", "Parker", 9, "M", false, 0);

        Store store = new Store();


        store.AddCustomer("John", "Doe", 22, "M", true, 0.02);
        store.AddCustomer("Sam", "Brooks", 67, "F", true, 0.12);
        store.AddCustomer("Alois", "Winter", 15, "M", false, 0);
        store.AddCustomer("Ann", "Siemens", 44, "F", true, 0.09);
        store.AddCustomer("Peter", "Parker", 9, "M", false, 0);

        //Product p1 = new Product("Coca-cola", ProductCategories.Category.Drinks, 1.12);
        //Product p2 = new Product("Tomatoes", ProductCategories.Category.FruitsAndVegetables, 0.99);
        //Product p3 = new Product("Lay’s Cheese", ProductCategories.Category.Snacks, 2.49);
        //Product p4 = new Product("Norway Herrin", ProductCategories.Category.Fish, 4.55);


        store.AddProduct("Coca-cola", ProductCategories.Category.Drinks, 1.12, 1);
        store.AddProduct("Tomatoes", ProductCategories.Category.FruitsAndVegetables, 0.99, 1);
        store.AddProduct("Lay’s Cheese", ProductCategories.Category.Snacks, 2.49, 1);
        store.AddProduct("Norway Herring", ProductCategories.Category.Fish, 4.55, 1);

        store.Customers[0].AddProductsToCart(store.Products[0], 2);
        store.Customers[0].AddProductsToCart(store.Products[3], 1);
        store.Customers[0].AddProductsToCart(store.Products[1], 7);
        store.Customers[2].AddProductsToCart(store.Products[1], 3);
        store.Customers[4].AddProductsToCart(store.Products[2], 5);
        store.Customers[4].AddProductsToCart(store.Products[0], 2);

        store.UpdateDiscountCard("Ann Siemens", false);
        store.UpdateCustomerName("John Doe", "John", "Claus");


        store.PrintCustomerInformation();

    }
}



