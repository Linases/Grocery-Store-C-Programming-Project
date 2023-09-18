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
        public override ProductCategories Category => ProductCategories.Meat;

        public Meat (string name, double price, int expirationDays = 1) : base(name, price, expirationDays)
        {
        }

    }
}

