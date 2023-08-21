using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryStore.Constants;



namespace GroceryStore.Models
{
    public abstract class Product
    {
        protected string Name { get; set; }
        protected ProductCategories.Category Category { get; }
        public double Price { get; set; }
        protected DateTime ExpirationDate { get; set; }
        protected int ExpirationDays { get; set; }

        protected Product(string name, ProductCategories.Category categoryName, double price, int expirationDays = 1)
        {
            Name = name;
            Category = categoryName;
            Price = price;
            ExpirationDays = expirationDays;
            ExpirationDate = DateTime.Today.AddDays(expirationDays);
        }

        public override string ToString()
        {
            return $"({Category}) {Name} {Price:C}, Exp. {ExpirationDate.ToString("dd.MM.yyyy")}";
        }
    }
}


