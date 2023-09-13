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
        public override ProductCategories Category => ProductCategories.FruitsAndVegetables;

        public FruitsAndVegetables(string name, double price, double weight, int expirationDays = 4 ) : base(name, price, expirationDays)
        {
            Weight = weight;
        }

        public new string ToString()
        {
            return base.ToString()+ $",{Weight}kg.";
        }
    }
}
