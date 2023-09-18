using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;


namespace GroceryStore.Core.Helpers
{
    public static class CollectionHelper
    {
        public static void AddCustomer<T>(this ICollection<T> customers, T customer)
        {
            {
                customers.Add(customer);
                JsonHelper.SetData(customers, @"C:\Users\lina.seskiene\source\repos\Linases\Grocery-Store-C-Programming-Project\GroceryStore\GroceryStore\Resources\customers.json");
            }
        }
        public static void AddProduct<T>(this ICollection<T> products, T product)

        {
            products.Add(product);
            JsonHelper.SetData(products, @"C:\Users\lina.seskiene\source\repos\Linases\Grocery-Store-C-Programming-Project\GroceryStore\GroceryStore\Resources\products.json");
        }

    }
}
