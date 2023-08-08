using System.Globalization;

namespace GroceryStore.Constants;

public class ProductCategories
{
    public enum Category
    {
        FruitsAndVegetables,
        Meat,
        Fish,
        Snacks,
        Drinks
    }
    public static string SelectCategory(Category categoryName)
    {
        switch (categoryName)
        {
            case Category.FruitsAndVegetables:
                {
                    return "Fruits & Vegetables";
                }
            case Category.Meat:
                {
                    return "Meat";
                }
            case Category.Snacks:
                {
                    return "Snacks";
                }
            case Category.Drinks:
                {
                    return "Drinks";
                }
            case Category.Fish:
                { 
                    return "Fish";
                }
                default:
                {
                    return "Unknown Category";
                }
        }

    }


}