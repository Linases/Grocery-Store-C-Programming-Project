using GroceryStore.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class Meat : Product
    {
        public Meat (string name, double price, int expirationDays = 1) : base(name, ProductCategories.Category.Meat, price, expirationDays)
        {
        }

        public override string ToString()
        {
            return $"({Category}) {Name} {Price:C}, Exp. {ExpirationDate.ToString("dd.MM.yyyy")}";
        }
    }
}

