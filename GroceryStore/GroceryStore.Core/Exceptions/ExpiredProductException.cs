using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Core.Exceptions
{
    public class ExpiredProductException : Exception
    {
        public string CustomerFullName { get; set; }
        public List<string> ExpiredProducts { get; set; } = new List<string>();
        public DateTime ExpiryDate { get; set; }

        public ExpiredProductException(string customerFullName, string expiredProducts, DateTime expiryDate)
        {
            CustomerFullName = customerFullName;
            ExpiredProducts.Add(expiredProducts);
            ExpiryDate = expiryDate;
        }

        public override string Message
        {
            get
            {
                string productNames = string.Join(", ", ExpiredProducts.Select(s => s));
                return $"Customer {CustomerFullName} is unable to buy the following products: {productNames} according to expiry date {ExpiryDate.ToShortDateString()}.";
            }
        }
    }
}





