using GroceryStore.Constants;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Xml.Linq;

namespace GroceryStore.Models
{
    public class Customer
    {

        //fields & properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        private bool _hasDiscountCard;
        public bool HasDiscountCard
        {

            get
            { return _hasDiscountCard; }
            set
            { _hasDiscountCard = value; }
        }
        public string DiscountCardToString
        {
            get
            {
                return _hasDiscountCard ? "Yes" : "No";
            }
        }

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
        public string PercentageAsString
        {
            get
            {
                return (PersonalDiscount * 100).ToString("0.##") + "%";
            }
        }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public Product[] Cart { get; set; }
        public int CartCount { get; set; }


        public Customer(string firstName, string lastName, int age, string sex, bool hasDiscountCard, double personalDiscount)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Sex = sex;
            HasDiscountCard = hasDiscountCard;
            PersonalDiscount = personalDiscount;
            Cart = new Product[10];
            CartCount = 0;
        }
        public void AddProductsToCart(Product product, int amount)

        {
            Cart[CartCount] = product.Copy(amount);
            CartCount++;
        }

        public void UpdateName(string newFirstName, string newLastName)
        {
            FirstName = newFirstName;
            LastName = newLastName;
        }

        public void UpdateDiscount(bool hasDiscountCard)
        {
            HasDiscountCard = hasDiscountCard;
        }
        public string GetCustomerInfo()
        {
            if (CartCount == 0)
            {
                return "EMPTY";
            }
            else
            {
                double totalCartSum = 0;
                string cartValue = "";
                
                for (int i = 0; i < CartCount; i++)
                {
                    double productTotal = Cart[i].Price * Cart[i].Amount;
                    cartValue += $"({Cart[i].GetProductInfo()}- {Cart[i].Amount}x - \n \t \t\t \t\t \t\t \t {productTotal}";
                    totalCartSum = totalCartSum + productTotal;
                }
                if (HasDiscountCard)
                {
                    totalCartSum *= (1 - PersonalDiscount);
                }
                cartValue += $"TOTAL = {totalCartSum} - DISCOUNT - {HasDiscountCard} ? {PersonalDiscount} : - {totalCartSum}";
                return cartValue;
            }
                
        }

    }
}

