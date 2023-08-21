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

        public string isAlcoholToString
        {
            get
            {
                return IsAlcohol ? "Y" : "N";
            }
        }

        double Volume { get; set; }

        public Drink(string name, double price, double volume, int expirationDays = 30, bool isAlcohol = false) : base(name, ProductCategories.Category.Drinks, price, expirationDays)
        {
            IsAlcohol = isAlcohol;
            Volume = volume;
        }

        public override string ToString()
        {
            return $"({Category}) {Name} {Price:C}, Exp. {ExpirationDate.ToString("dd.MM.yyyy")}, Vol. {Volume}, Alcohol - {isAlcoholToString}";
        }
    }
}
