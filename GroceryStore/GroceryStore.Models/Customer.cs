using GroceryStore.Constants;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Transactions;
using System.Xml.Linq;

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

        public Product[] Cart { get; set; }
        public int CartCount { get; set; }

        public Customer(string firstName, string lastName, int age, string sex, bool hasDiscountCard, double personalDiscount = 0.02)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Sex = sex;
            HasDiscountCard = hasDiscountCard;
            PersonalDiscount = personalDiscount;
            Cart = new Product[100];
            CartCount = 0;
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
            for (int i = 0; i < amount; i++)
            {
                Cart[CartCount] = product;
                CartCount++;
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
            if (CartCount == 0)
            {
                return "EMPTY";
            }
            else
            {
                double totalCartSum = 0;
                string cartValue = string.Empty;
                double totalDiscountSum = 0;

                Product[] uniqueProducts = new Product[CartCount];
                int uniqueProductsCount = 0;

                for (int i = 0; i < CartCount; i++)
                {
                    bool existsInUniqueProducts = false;

                    for (int j = 0; j < uniqueProductsCount; j++)
                    {
                        if (Cart[i] == uniqueProducts[j])
                        {
                            existsInUniqueProducts = true;
                            break;
                        }
                    }

                    if (existsInUniqueProducts == false)
                    {
                        uniqueProducts[uniqueProductsCount] = Cart[i];
                        uniqueProductsCount++;
                    }
                }

                for (int i = 0; i < uniqueProductsCount; i++)
                {
                    int amount = 0;

                    for (int j = 0; j < CartCount; j++)
                    {
                        if (uniqueProducts[i] == Cart[j])
                        {
                            amount++;
                        }
                    }
                    double productTotal = uniqueProducts[i].Price * amount;
                    cartValue += $"({uniqueProducts[i]} - {amount}x - {productTotal:C}\n\t\t\t \t\t \t\t \t";
                    totalCartSum = totalCartSum + productTotal;
                    totalDiscountSum = totalCartSum * (1 - PersonalDiscount);
                }

                return cartValue;
            }
        }

    }
}

