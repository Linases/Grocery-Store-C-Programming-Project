using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class Store
    {
        public Customer[] Customers { get; set; }
        public Product[] Products { get; set; }

        private int currentIndex;

        public Store(int numberOfCustomers)
        {
            Customers = new Customer[numberOfCustomers];
            currentIndex = 0;
        }
        public void AddCustomer(string firstName, string lastName, int age, string sex, bool hasDiscountCard, double personalDiscount)
        {
            if (currentIndex < Customers.Length)
            {
                Customers[currentIndex] = new Customer(firstName, lastName, age, sex, hasDiscountCard, personalDiscount);
                currentIndex++;
            }
        }

        public void UpdateCustomerName(string fullName, string newFirstName, string newLastName)
        {
            foreach (var customer in Customers)
            {
                if (customer.FullName == fullName)
                {
                    customer.UpdateName(newFirstName, newLastName);
                }
            }
        }

        public void UpdateDiscountCard(bool hasDiscountCard)
        {
            foreach (var customer in Customers)
            {
                if (customer.FullName == "Ann Siemens")
                {
                    customer.UpdateDiscount(hasDiscountCard);
                }
            }
        }

        public void PrintCustomerInformation()
        {
             Console.WriteLine($"|Full Name | Sex| Has Discout Card | Personal Discount|Cart|");

            foreach (Customer customer in Customers)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine(customer.GetCustomerInfo());
            }
        }
    }
}
