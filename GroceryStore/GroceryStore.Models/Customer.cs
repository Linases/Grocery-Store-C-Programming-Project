using System.Globalization;

namespace GroceryStore.Models
{
    public class Customer
    {
        //fields or properties
        //private string FirstName;
        //private string LastName;
        //private int Age;
        //private string Sex;
        //private bool HasDiscountCard;
        //private double PersonalDiscount;

        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public bool HasDiscountCard { get; set; }
        public double PersonalDiscount { get; set; }
        //    get
        //    {
        //        return this.HasDiscountCard ? this.PersonalDiscount : 0;
        //    };
        //    set;
        //}

        string Cart { get; set; }   
        //constructors with arguments   //
        public Customer(string firstName, string lastName, int age, string sex, bool hasDiscountCard, double personalDiscount, string cart)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Sex = sex;
            this.HasDiscountCard = hasDiscountCard;
            this.PersonalDiscount = personalDiscount;
            this.Cart = cart;
        }

        public string GetFullName()
        {
            return $"{this.FirstName} {this.LastName}";
        }

        /*public bool GetPersonalDiscount()
        {
            if (bool hasPersonalDiscount = false) {
                double hasPersonalDiscount = 0
                return { hasPersonalDiscount}
            }
        }*/

        public override string ToString()
        {
            return $" {GetFullName()}, {Age}, {Sex}, {HasDiscountCard}, {PersonalDiscount}, {Cart}";
        }
    }
}