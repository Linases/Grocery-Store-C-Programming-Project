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

        // Console.WriteLine(c1.ToString());
        Store store = new Store(5);

        store.AddCustomer("John", "Doe", 22, "M", true, 0.02);
        store.AddCustomer("Sam", "Brooks", 67, "F", true, 0.12);
        store.AddCustomer("Alois", "Winter", 15, "M", false, 0);
        store.AddCustomer("Ann", "Siemens", 44, "F", true, 0.09);
        store.AddCustomer("Peter", "Parker", 9, "M", false, 0);

        //Product p1 = new Product("Coca-cola", ProductCategories.Category.Drinks, 1.12);
        //Product p2 = new Product("Tomatoes", ProductCategories.Category.FruitsAndVegetables, 0.99);
        //Product p3 = new Product("Lay’s Cheese", ProductCategories.Category.Snacks, 2.49);
        //Product p4 = new Product("Norway Herrin", ProductCategories.Category.Fish, 4.55);

        //Console.WriteLine(p1);

        store.UpdateDiscountCard(false);
        store.UpdateCustomerName("John Doe", "John", "Claus");
        store.PrintCustomerInformation();

    }
    }



