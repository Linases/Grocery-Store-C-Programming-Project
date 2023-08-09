using System.Globalization;

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
                return _hasDiscountCard? "Yes" : "No";

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
                return (_personalDiscount * 100).ToString("0.##") + "%";
            }
        }
       
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        private string _cart;
        public string Cart
        {
            get
            {
                return (_cart == null) ? "EMPTY" : "NOT EMPTY";
            }
          
        }

        public Customer(string firstName, string lastName, int age, string sex, bool hasDiscountCard, double personalDiscount)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Sex = sex;
            HasDiscountCard = hasDiscountCard;
            PersonalDiscount = personalDiscount;
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
          
           return  $"|{FullName}|{Sex}|{DiscountCardToString}|{PercentageAsString} | {Cart}|";
        }
        //public override string ToString()
        //{
        //    return $" {FirstName}, {LastName}, {Age}, {Sex}, {HasDiscountCard}, {PercentageAsString}";
        //}
    }
}
