namespace AbstractFactoryTester
{
    public class ShapeFactory : AbstractFactory
    {
        public override IColor getColor(string color)
        {
            return null;
        }

        public override IShape getShape(string shapeType)
        {
            if (string.IsNullOrWhiteSpace(shapeType))
            {
                return null;
            }

            if (shapeType.ToLower() == "circle")
            {
                return new Circle();
            }

            if (shapeType.ToLower() == "rectangle")
            {
                return new Rectangle();
            }

            if (shapeType.ToLower() == "square")
            {
                return new Square();
            }

            return null;
        }
    }
}