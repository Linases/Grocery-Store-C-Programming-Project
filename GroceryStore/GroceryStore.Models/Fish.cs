using GroceryStore.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class Fish : Product
    {
        public ProductCategories.FishType FishType { get; set; }

        public Fish(string name, double price, ProductCategories.FishType fishType, int expirationDays = 1) : base(name, ProductCategories.Category.Fish, price, expirationDays)
        {
            FishType = fishType;
        }


        public override string ToString()
        {
            return $"({Category}) {Name} {Price:C}, Exp. {ExpirationDate.ToString("dd.MM.yyyy")}, {FishType}";
        }
    }
}
