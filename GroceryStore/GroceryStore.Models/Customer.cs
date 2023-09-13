using GroceryStore.Constants;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Transactions;
using System.Xml.Linq;
using GroceryStore.Core.Exceptions;


namespace GroceryStore.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public bool HasDiscountCard { get; set; }

        private double _personalDiscount;
        public double PersonalDiscount
        {
            get
            {
                return (HasDiscountCard ? _personalDiscount : 0);
            }
            set
            {
                _personalDiscount = value;
            }
        }
        public string FullName => $"{FirstName} {LastName}";

        public List<Product> Cart { get; set; }

        public Customer(string firstName, string lastName, int age, string sex, bool hasDiscountCard, double personalDiscount = 0.02)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Sex = sex;
            HasDiscountCard = hasDiscountCard;
            PersonalDiscount = personalDiscount;
            Cart = new List<Product>();

        }
        private string DiscountCardToString()
        {
            return HasDiscountCard ? "Yes" : "No";
        }
        private string ConvertDiscountCardToString()
        {
            return (PersonalDiscount * 100).ToString("0.##") + "%";
        }

        public void AddProductsToCart(Product product, int amount)
        {

            try
            {
                if (product.AgeRestrictedProduct && this.Age < 18)
                {
                    throw new UnderAgeException(this.FullName, product.Name);
                }
                else if (product.ExpirationDate < DateTime.Today)
                {
                    throw new ExpiredProductException(this.FullName, product.Name, product.ExpirationDate);
                }
                for (int i = 0; i < amount; i++)
                {
                    Cart.Add(product);
                    Console.WriteLine($"Added product '{product.Name}' to the cart.");
                }
            }

            catch (UnderAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ExpiredProductException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateName(string newFirstName, string newLastName)
        {
            FirstName = newFirstName;
            LastName = newLastName;
        }
        public void UpdateDiscount(bool hasDiscountCard, double personalDiscount = 0.02)
        {
            HasDiscountCard = hasDiscountCard;
            PersonalDiscount = personalDiscount;
        }
        public override string ToString()
        {
            return $"| {FullName,-13} |  {Age,3} | {Sex,3} | {DiscountCardToString(),12} | {ConvertDiscountCardToString(),16}| {GetCustomerCartInfo()}";
        }

        private string GetCustomerCartInfo()
        {
            if (Cart.Count == 0)
            {
                return "EMPTY";
            }
            else
            {
                //    from products
                //    select product.Name, product.Price, product.Count
                //    group by product.Name, product.Price

                double totalCartSum = 0;
                string cartValue = string.Empty;
                double totalDiscountSum = 0;


                //List<Product> uniqueProducts = new List<Product>();

                //for (int i = 0; i < Cart.Count; i++)
                //{
                //    bool existsInUniqueProducts = false;

                //    for (int j = 0; j < uniqueProducts.Count; j++)
                //    {
                //        if (Cart[i] == uniqueProducts[j])
                //        {
                //            existsInUniqueProducts = true;
                //            break;
                //        }
                //    }

                //    if (existsInUniqueProducts == false)
                //    {
                //        uniqueProducts.Add(Cart[i]);
                //    }
                //}

                //for (int i = 0; i < uniqueProducts.Count; i++)
                //{
                //    int amount = 0;

                //    for (int j = 0; j < Cart.Count; j++)
                //    {
                //        if (uniqueProducts[i] == Cart[j])
                //        {
                //            amount++;
                //        }
                //    }
                //    double productTotal = uniqueProducts[i].Price * amount;
                //    cartValue += $"({uniqueProducts[i]} - {amount}x - {productTotal:C}\n\t\t\t \t\t \t\t \t";
                //    totalCartSum = totalCartSum + productTotal;
                //    totalDiscountSum = totalCartSum * (1 - PersonalDiscount);
                //}

                return cartValue;
            }
        }

    }
}

