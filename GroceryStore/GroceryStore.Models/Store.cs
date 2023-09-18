using GroceryStore.Constants;
using GroceryStore.Core.Helpers;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GroceryStore.Models
{
    public static class Store
    {
        private static HashSet<Customer> _customers { get; set; } = new HashSet<Customer>();
        private static HashSet<Product> _products { get; set; } = new HashSet<Product>();

        private static HashSet<Customer> Customers { get { return _customers; } }
        private static HashSet<Product> Products { get { return _products; } }

        public static void AddCustomer(string firstName, string lastName, int age, string sex, bool hasDiscountCard, double personalDiscount = 0)
        {
            Customer customer = new Customer(firstName, lastName, age, sex, hasDiscountCard, personalDiscount);
            CollectionHelper.AddCustomer(Customers, customer);
        }

        public static void AddProduct(Product product)
        {
            CollectionHelper.AddProduct(Products, product);
        }

        public static void UpdateCustomer(string fullName, string newFirstName, string newLastName)
        {
            foreach (var customer in Customers)
            {
                if (customer.FullName == fullName)
                {
                    customer.UpdateName(newFirstName, newLastName);
                    JsonHelper.SetData(Customers, @"C:\Users\lina.seskiene\source\repos\Linases\Grocery-Store-C-Programming-Project\GroceryStore\GroceryStore\Resources\customers.json");
                }
            }
        }

        public static Customer GetCustomer(string fullName)
        {
            foreach (var customer in Customers)
            {
                if (customer.FullName == fullName)
                {
                    return customer;
                }
            }
            throw new Exception("Customer not found: " + fullName);
        }

        public static Product GetProduct(string productName)
        {
            foreach (var product in Products)
            {
                if (product.Name == productName)
                {
                   return product;
                }
            }
            throw new Exception("Product not found: " + productName);
        }

        public static void UpdateDiscountCard(string fullName, bool hasDiscountCard)
        {
            foreach (var customer in Customers)
            {
                if (customer.FullName == fullName)
                {
                    customer.UpdateDiscount(hasDiscountCard);
                }
            }
        }

        public static void AddProductsToCart(string fullName, string productName, int amount)
        {
            GetCustomer(fullName).AddProductsToCart(GetProduct(productName), amount);
            JsonHelper.SetData(Customers, @"C:\Users\lina.seskiene\source\repos\Linases\Grocery-Store-C-Programming-Project\GroceryStore\GroceryStore\Resources\customers.json");
        }
        public static void PrintCustomerInformation()
        {
            Console.WriteLine(new string('-', 138));
            Console.WriteLine("| Full Name     | Age  | Sex  |Has Discount |Personal Discount|              Cart                ");
            Console.WriteLine(new string('-', 138));

            foreach (var customer in Customers)
            {
                Console.WriteLine(customer);
                Console.WriteLine(new string('-', 138));
            }
        }
    }
}
