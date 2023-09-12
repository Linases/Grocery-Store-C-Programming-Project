using GroceryStore.Constants;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GroceryStore.Models
{
    public static class Store
    {
        public static List<Customer> Customers { get; set; } = new List<Customer>();
        public static List<Product> Products { get; set; } = new List<Product>();
        
        public static void AddCustomer(string firstName, string lastName, int age, string sex, bool hasDiscountCard, double personalDiscount = 0)
        {
            {
                Customer customer = new Customer(firstName, lastName, age, sex, hasDiscountCard, personalDiscount);
                Customers.Add(customer);
            }
        }
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static void UpdateCustomerName(string fullName, string newFirstName, string newLastName)
        {
            for (int i = 0; i < Customers.Count; i++)

                if (Customers[i].FullName == fullName)
                {
                    Customers[i].UpdateName(newFirstName, newLastName);
                }
        }
        public static void UpdateDiscountCard(string fullName, bool hasDiscountCard)
        {
            for (int i = 0; i < Customers.Count; i++)
            {
                if (Customers[i].FullName == fullName)
                {
                    Customers[i].UpdateDiscount(hasDiscountCard);
                }
            }
        }
        public static void PrintCustomerInformation()
        {
            Console.WriteLine(new string('-', 138));
            Console.WriteLine("| Full Name     | Age  | Sex  |Has Discount |Personal Discount|              Cart                ");
            Console.WriteLine(new string('-', 138));

            for (int i = 0; i < Customers.Count; i++)
            {
                Console.WriteLine(Customers[i]);
                Console.WriteLine(new string('-', 138));
            }
        }
    }
}
