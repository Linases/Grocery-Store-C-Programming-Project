using System.Globalization;

namespace GroceryStore.Constants;

public static class ProductCategories
{
    public enum Category
    {
        FruitsAndVegetables,
        Meat,
        Fish,
        Snacks,
        Drinks
    }
    public static string SelectCategory(Category category)
    {
        switch (category)
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