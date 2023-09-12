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
        public abstract ProductCategories.Category Category { get;  }
        public double Price { get; set; }

        public int ExpirationDays = 1;
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


