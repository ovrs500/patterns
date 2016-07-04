namespace Prototype
{
    public class Circle : Shape
    {
        public Circle()
        {
            _type = "Circle";
        }

        public override string draw()
        {
            return "Inside circle draw() method";
        }
    }
}