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
        //public string Name;
        //public string Category;
        //public double Price;


        public string Name { get; set; }
        public ProductCategories.Category Category {get; set; }

        public double Price { get; set; }

        
        public Product(string name, ProductCategories.Category categoryName, double price)
        {
            this.Name = name;
            this.Category = categoryName;
            this.Price = price;
        }

        public override string ToString()
        {
            return $" {Name}, {Category}, {Price}";
        }

    }
}


