using GroceryStore.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class Snacks : Product
    {
        [JsonInclude]
        public bool IsNoFat { get; set; }
        public override ProductCategories Category => ProductCategories.Snacks;

        public Snacks(string name, double price, bool isNotFat = false, int expirationDays = 90) : base(name, price, expirationDays)
        {
            IsNoFat = isNotFat;
        }

        private string isNotFatToString()
        {
            return !IsNoFat ? "Y" : "N";
        }

        public new string ToString()
        {
            return base.ToString()+ $", Fat - {isNotFatToString()}";
        }
    }
}
