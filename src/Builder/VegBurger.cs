namespace Builder
{
    public class VegBurger : Burger
    {
        public override string name()
        {
            return "Veg Buger";
        }

        public override float price()
        {
            return 25.0f;
        }
    }
}