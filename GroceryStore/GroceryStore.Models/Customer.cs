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
        public bool HasDiscountCard { get; set; }

        private double personalDiscount;

        public double PersonalDiscount
        {
            get
            {
                return (HasDiscountCard ? personalDiscount : 0);
            }
            set
            {
                personalDiscount = value;

            }
        }
        public string PercentageAsString
        {
            get
            {
                return (personalDiscount * 100).ToString("0.##") + "%";
            }
        }
        public string Fullname
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        private string cart;
        public string Cart
        {
            get
            {
                return (cart == null) ? "EMPTY" : "NOT EMPTY";
            }
            set
            {
                cart = value;
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
        public void GetCustomerInfo()
        {
            Console.WriteLine("-------------------------------------------------");

            string customerInfo = $"|    {Fullname} |  {Sex}  |  {HasDiscountCard}  | {PercentageAsString}  | {Cart}   |";
            Console.WriteLine(customerInfo);
        }
        public override string ToString()
        {
            return $" {FirstName}, {LastName}, {Age}, {Sex}, {HasDiscountCard}, {PercentageAsString}";
        }
    }
}
