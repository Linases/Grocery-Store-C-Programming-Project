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

namespace GroceryStore.Models
{
    public abstract class Product
    {
        public string Name { get; set; }
        public abstract ProductCategories Category { get; }
        public double Price { get; set; }

        public int ExpirationDays = 1;

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
    }
}


