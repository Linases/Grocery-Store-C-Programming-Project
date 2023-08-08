using GroceryStore.Models;


public class Program
{
    public static void Main(string[] args)
    {

        Customer c1 = new Customer("John", "Doe", 22, "M", true, 0.02);
        Customer c2 = new Customer("Sam", "Brooks", 67, "F", true, 0.12);
        Customer c3 = new Customer("Alois", "Winter", 15, "M", false, 0);
        Customer c4 = new Customer("Ann", "Siememns", 44, "F", true, 0.09);
        Customer c5 = new Customer("Peter", "Parker", 9, "M", false, 0);
       
        Store.AddCustomer(c1);
        Store.AddCustomer(c2);
        Store.AddCustomer(c3);
        Store.AddCustomer(c4);
        Store.AddCustomer(c5);

        //Store.AddCustomer("Nastya", "Siamenava", 23, "f", false, 0.01);
       // Store.AddCustomer(c1.Firstname, c1.Lastname, c1.Age, c1.Sex, c1.HasDiscountCard, c1.PersonalDiscount);
       
        Product p1 = new Product("Coca-cola", "Drinks", 1.12);
        Product p2 = new Product("Tomatoes", "fruits$vedgetables", 0.99);
        Product p3 = new Product("Lay’s Cheese", "Snacks", 2.49);
        Product p4 = new Product("Norway Herrin", "Fish", 4.55);
        p1.ToString();
        Console.WriteLine(p1);

       
    }
}

