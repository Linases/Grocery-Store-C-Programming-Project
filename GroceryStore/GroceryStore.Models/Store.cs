﻿using GroceryStore.Constants;
using GroceryStore.Core.Helpers;
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
        private static HashSet<Customer> _customers { get; set; } = new HashSet<Customer>();
        private static HashSet<Product> _products { get; set; } = new HashSet<Product>();

        public static HashSet<Customer> Customers { get { return _customers; } }
        public static HashSet<Product> Products { get { return _products; } }
        public static void LoadCustomers()
        {
            JsonHelper.GetData<Customer>("customers.json");
        }
        public static void Loadproducts()
        {
            JsonHelper.GetData<Product>("products.json");
        }

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
            foreach (var customer in Customers)
            {
                if (customer.FullName == fullName)
                {
                    customer.UpdateName(newFirstName, newLastName);
                    JsonHelper.SetData( Customers,"customers.json");
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
