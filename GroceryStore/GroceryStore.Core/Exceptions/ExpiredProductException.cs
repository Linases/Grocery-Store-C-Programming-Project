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
        public List<string> ExpiredProducts { get; set; }
        public DateTime ExpiryDate { get; set; }

        public ExpiredProductException(string message) : base(message) { }
        public ExpiredProductException(string message, Exception innerException) : base(message, innerException)
        { }
        public ExpiredProductException(string customerFullName, List<string> expiredProducts, DateTime expiryDate)
        {
            CustomerFullName = customerFullName;
            ExpiredProducts = expiredProducts;
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

        
      
    

