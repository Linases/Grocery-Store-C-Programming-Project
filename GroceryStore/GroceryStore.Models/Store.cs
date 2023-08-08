using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public static class Store
    {
        public static List<Customer> Customers { get; set; }
        public static List<Product> Products { get; set; }
        
        public static void AddCustomer(string firstName, string lastName, int age, string sex, bool hasDiscountCard, double personalDiscount)
        {
            var customer = new Customer(firstName, lastName, age, sex, hasDiscountCard, personalDiscount);
            Customers.Add(customer);
        }

        public static void AddCustomer(Customer customer) => Customers.Add(customer);
    }
}
