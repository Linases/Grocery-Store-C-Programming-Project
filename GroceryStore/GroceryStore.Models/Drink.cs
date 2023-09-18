using GroceryStore.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class Drink : Product
    {
        [JsonInclude]
        public bool IsAlcohol { get; set; }
        [JsonInclude]
        public double Volume { get; set; }

        public override ProductCategories Category => ProductCategories.Drinks;

        public Drink(string name, double price, double volume, bool isAlcohol = false, int expirationDays = 30) : base(name, price, expirationDays)
        {
            IsAlcohol = isAlcohol;
            Volume = volume;
            AgeRestrictedProduct = isAlcohol;
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
