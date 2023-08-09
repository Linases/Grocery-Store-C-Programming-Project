using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public static class Store
    {
        public static List<Customer> CustomerList;
        public static List<Product> ProductList;

        //public void AddCustomer(string firstName, string lastName, int age, string sex, bool hasDiscountCard, double personalDiscount)
        //{
        //    var customer = new Customer(firstName, lastName, age, sex, hasDiscountCard, personalDiscount);
        //    CustomerList.Add(customer);
        //}
        public static void AddCustomer(Customer customer) => CustomerList.Add(customer);

        public static void PrintCustomerInformation()
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine($"| Full Name      |  Sex  |  Has Discout Card  | Personal Discount | Cart  |");

            foreach (Customer customer in CustomerList)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
