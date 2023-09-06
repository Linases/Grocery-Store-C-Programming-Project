using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Core.Exceptions
{
   public class UnderAgeException: Exception
    {
        public string CustomerFullName { get; set; }
        public List<string> RestrictedProducts { get; set; }
        public UnderAgeException(string message) : base(message) { }
        public UnderAgeException(string message, Exception innerException) : base(message, innerException)
        { }
        public UnderAgeException(string customerFullName, List <string>restrictedProducts)
        {
            CustomerFullName = customerFullName;
            RestrictedProducts = restrictedProducts;
        }

        public override string Message
        {
            get
            {
                return $"Customer {CustomerFullName} is unable to buy the following products: {string.Join(", ", RestrictedProducts)} according to age restrictions.";
            }
        }
    }
}
