using GroceryStore.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class Snacks : Product
    {
        public bool IsNoFat { get; set; }

        public Snacks(string name, double price, bool isNotFat = false, int expirationDays = 90) : base(name, ProductCategories.Category.Snacks, price, expirationDays)
        {
            IsNoFat = isNotFat;
        }

        private string isNotFatToString()
        {
            return !IsNoFat ? "Y" : "N";
        }
        public override string ToString()
        {
            return $"({Category}) {Name} {Price:C}, Exp. {ExpirationDate.ToString("dd.MM.yyyy")}, Fat - {isNotFatToString()}";
        }
    }
}
