namespace Patterns.Factory
{
    public class ShapeFactory
    {
        public IShape getShape(
            string shapeType)
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