using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class Product
    {
        //public string Name;
        //public string Category;
        //public double Price;


        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        public Product(string name, string category, double price)
        {
            this.Name = name;
            this.Category = category;
            this.Price = price;
        }

    }
}

