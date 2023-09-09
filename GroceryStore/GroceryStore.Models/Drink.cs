using GroceryStore.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class Drink : Product
    {
        public bool IsAlcohol { get; set; }

        double Volume { get; set; }

        public override ProductCategories.Category Category => ProductCategories.Category.Drinks;

        public Drink(string name, double price, double volume, bool isAlcohol = false, int expirationDays = 30) : base(name, price, expirationDays)
        {
            IsAlcohol = isAlcohol;
            Volume = volume;
        }

        private string isAlcoholToString()
        {
            return IsAlcohol ? "Y" : "N";
        }

        public new string ToString() 
        {
            return base.ToString() + $", Vol. {Volume}, Alcohol - {isAlcoholToString()}";
        }
    }
}
