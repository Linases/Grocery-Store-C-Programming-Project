using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace GroceryStore.Core.Helpers
{
   public static class CollectionHelper
    {
        public static void AddCustomer<T>(this HashSet<T> customers, T customer, string jsonFilePath)
        {
            {
                customers.Add(customer);
                JsonHelper.SetData<T>(jsonFilePath, customer);
            }
        }
        public static void AddProduct<T>(this HashSet<T> products,T product, string jsonFilePath)
        
        {
            products.Add(product);
            JsonHelper.SetData<T>(jsonFilePath, product);
        }

    }
}
