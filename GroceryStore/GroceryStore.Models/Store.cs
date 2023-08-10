using GroceryStore.Constants;
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
        public int CustomerCount { get; set; }
        public int ProductCount { get; set; }

        public Store()
        {
            Customers = new Customer[10];
            Products = new Product[10];
            CustomerCount = 0;
            ProductCount =0;
        }

        public void AddCustomer(string firstName, string lastName, int age, string sex, bool hasDiscountCard, double personalDiscount)
        {
            
            {
                Customer customer = new Customer(firstName, lastName, age, sex, hasDiscountCard, personalDiscount);
                Customers[CustomerCount] = customer;
                CustomerCount++;
            }
        }

        public void AddProduct(string name, ProductCategories.Category categoryName, double price, int amount)
        
            {
                Product products = new Product(name, categoryName, price, amount);
                Products[ProductCount]= products;
                ProductCount++;
            }
        
        public void UpdateCustomerName(string fullName, string newFirstName, string newLastName)
        {
             for (int i = 0; i < CustomerCount; i++)
                
                if (Customers[i].FullName == fullName)
                {
                    Customers[i].UpdateName(newFirstName, newLastName);
                }
            }
        

        public void UpdateDiscountCard(string fullName, bool hasDiscountCard)
        {
            for (int i = 0;i < CustomerCount; i++)  
            {
                if (Customers[i].FullName == fullName)
                {
                    Customers[i].UpdateDiscount(hasDiscountCard);
                }
            }
        }

        public void PrintCustomerInformation()
        {
            Console.WriteLine(new string('-', 118));
            Console.WriteLine("| Customer Name | Age | Sex  |Has Discount    |Personal Discount|              Cart                ");
            Console.WriteLine(new string('-', 118));

            for (int i = 0; i < CustomerCount; i++) 
            {
                Console.WriteLine($"| {Customers[i].FullName,-19} |  {Customers[i].Age,3} | {Customers[i].Sex,3} | {Customers[i].DiscountCardToString,12} | {Customers[i].PercentageAsString,16} | {Customers[i].GetCustomerInfo()}");
                Console.WriteLine(new string('-', 118)); ;
            }
        
        }

    }
}
