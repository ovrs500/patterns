namespace Builder
{
    public class MealBuilder
    {
        public Meal prepareVegMeal()
        {
            var meal = new Meal();

            meal.addItem(new VegBurger());
            meal.addItem(new Coke());

            return meal;
        }

        public Meal prepareNonVegMeal()
        {
            var meal = new Meal();

            meal.addItem(new ChickenBurger());
            meal.addItem(new Pepsi());

            return meal;
        }
    }
}