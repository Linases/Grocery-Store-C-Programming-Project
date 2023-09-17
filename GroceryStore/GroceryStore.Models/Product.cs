using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryStore.Constants;
using System.Text.Json;
using Microsoft.VisualBasic;
using System.Text.Json.Serialization;

namespace GroceryStore.Models
{
    public abstract class Product
    {
        public string Name { get; set; }
        public abstract ProductCategories Category { get; }
        public double Price { get; set; }

       int ExpirationDays = 1;
     
       public bool AgeRestrictedProduct { get; set; } = false;
        public DateTime ExpirationDate
        {
            get
            {
                return DateTime.Today.AddDays(ExpirationDays);
            }
        }
        public Product(string name, double price, int expirationDays)
        {
            Name = name;
            Price = price;
            ExpirationDays = expirationDays;
        }

        public override string ToString()
        {
            return $"({Category}) {Name} {Price:C}, Exp. {ExpirationDate.ToString("dd.MM.yyyy")}";
        }

        public string getProductInfo()
        {
            if (this is FruitsAndVegetables)
            {
                return ((FruitsAndVegetables)this).ToString();
            }
            if (this is Snacks)
            {
                return ((Snacks)this).ToString();
            }
            if (this is Fish)
            {
                return ((Fish)this).ToString();
            }
            if (this is Drink)
            {
                return ((Drink)this).ToString();
            }
     
            return ToString();
        }
    }
}


