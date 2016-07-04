namespace Prototype
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            _type = "Rectangle";
        }

        public override string draw()
        {
            return "Inside rectangle draw() method";
        }
    }
}