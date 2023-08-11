using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryStore.Constants;



namespace GroceryStore.Models
{
    public class Product
    {
        public string Name { get; set; }
        public ProductCategories.Category Category { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

            public Product(string name, ProductCategories.Category categoryName, double price, int amount=1)
        {
            this.Name = name;
            this.Category = categoryName;
            this.Price = price;
            this.Amount = amount;
        }
       
        public string GetProductInfo()
        {
            return $"({Category}) {Name} {Price:C}";
        }
        public Product Copy(int amount)
        {
            return new Product(Name, Category, Price, amount);
        }
    }
}


