using GroceryStore.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
   public class FruitsAndVegetables : Product
    {
        double Weight { get; set; } 

        public FruitsAndVegetables(string name, double price, double weight, int expirationDays =4 ) : base(name, ProductCategories.Category.FruitsAndVegetables, price, expirationDays)
        {
            Weight = weight;
        }

        public override string ToString()
        {
            return $"({Category}) {Name} {Price:C}, Exp. {ExpirationDate.ToString("dd.MM.yyyy")}, {Weight}kg.";
        }
    }
}
