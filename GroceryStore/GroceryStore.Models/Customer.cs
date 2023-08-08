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
        public double PersonalDiscount { 
            get
            {
                return (HasDiscountCard ? PersonalDiscount : 0);
            }
                set { PersonalDiscount = value; }
            }
        public string Fullname {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
        public List<Product>Cart { get; set; } 
        
        public Customer(string firstName, string lastName, int age, string sex, bool hasDiscountCard, double personalDiscount)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Sex = sex;
            this.HasDiscountCard = hasDiscountCard;
            this.PersonalDiscount = personalDiscount;
        }
        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
        public override string ToString()
        {
            return $" {GetFullName()}, {Age}, {Sex}, {HasDiscountCard}, {PersonalDiscount}";
        }
    }
}
