using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var mealBuilder = new MealBuilder();
            var vegMeal = mealBuilder.prepareVegMeal();
            var nonVegMeal = mealBuilder.prepareNonVegMeal();

            Console.WriteLine("Veg Meal");
            Console.WriteLine(vegMeal.showItems());
            Console.WriteLine("Total Cost: " + vegMeal.getCost());
            Console.WriteLine("");
            Console.WriteLine("Non Veg Meal");
            Console.WriteLine(nonVegMeal.showItems());
            Console.WriteLine("Total Cost: " + nonVegMeal.getCost());
            Console.ReadLine();
        }
    }
}