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
        public string isNotFatToString
        {
            get
            {
                return !IsNoFat ? "Y" : "N";
            }
        }

        public Snacks(string name, double price, bool isNotFat = false, int expirationDays = 90) : base(name, ProductCategories.Category.Snacks, price, expirationDays)
        {
            Name = name;
            Price = price;
            IsNoFat = isNotFat;
            ExpirationDays = expirationDays;
            DateTime ExpirationDate = DateTime.Today.AddDays(expirationDays);
        }

        public override string ToString()
        {
            return $"({Category}) {Name} {Price:C}, Exp. {ExpirationDate.ToString("dd.MM.yyyy")}, Fat - {isNotFatToString}";
        }
    }
}
