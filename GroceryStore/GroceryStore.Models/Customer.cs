using System.Globalization;

namespace GroceryStore.Models
{
    public class Customer
    {

        //fields & properties
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public bool HasDiscountCard { get; set; }
        public double PersonalDiscount { get; set; }
        public string Fullname { get; set; }

        public string Cart { get; set; }


        public Customer(string firstName, string lastName, int age, string sex, bool hasDiscountCard, double personalDiscount)
        {
            this.Firstname = firstName;
            this.Lastname = lastName;
            this.Age = age;
            this.Sex = sex;
            this.HasDiscountCard = hasDiscountCard;
            this.PersonalDiscount = personalDiscount;

        }
        public string GetFullName()
        {
            return this.Firstname + " " + this.Lastname;
        }

        public override string ToString()
        {
            return $" {GetFullName()}, {Age}, {Sex}, {HasDiscountCard}, {PersonalDiscount}";
        }
    }
}
