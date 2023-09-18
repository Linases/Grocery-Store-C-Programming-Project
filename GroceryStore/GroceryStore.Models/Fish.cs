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
        public FishType FishType { get; set; }
        public override ProductCategories Category => ProductCategories.Fish;

        public Fish(string name, double price, FishType fishType, int expirationDays = 1) : base(name, price, expirationDays)
        {
            FishType = fishType;
        }


        public new string ToString()
        {
            return base.ToString() + $" {FishType}";
        }
    }
}
