namespace AbstractFactoryTester
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(
            string choice)
        {
            if (choice.ToLower() == "shape")
            {
                return new ShapeFactory();
            }
            else if (choice.ToLower() == "color")
            {
                return new ColorFactory();
            }

            return null;
        }
    }
}