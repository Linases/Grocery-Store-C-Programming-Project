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
        public static Customer[] Customers { get; set; } = new Customer[10];
        public static Product[] Products { get; set; } = new Product[10];
        public static int CustomerCount { get; set; } = 0;
        public static int ProductCount { get; set; } = 0;

        public static void AddCustomer(string firstName, string lastName, int age, string sex, bool hasDiscountCard, double personalDiscount = 0)
        {
            {
                Customer customer = new Customer(firstName, lastName, age, sex, hasDiscountCard, personalDiscount);
                Customers[CustomerCount] = customer;
                CustomerCount++;
            }
        }
        public static void AddProduct(Product product)
        {

            Products[ProductCount] = product;
            ProductCount++;
        }

        public static void UpdateCustomerName(string fullName, string newFirstName, string newLastName)
        {
            for (int i = 0; i < CustomerCount; i++)

                if (Customers[i].FullName == fullName)
                {
                    Customers[i].UpdateName(newFirstName, newLastName);
                }
        }
        public static void UpdateDiscountCard(string fullName, bool hasDiscountCard)
        {
            for (int i = 0; i < CustomerCount; i++)
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

            for (int i = 0; i < CustomerCount; i++)
            {
                Console.WriteLine(Customers[i]);
                Console.WriteLine(new string('-', 138));
            }
        }
    }
}
