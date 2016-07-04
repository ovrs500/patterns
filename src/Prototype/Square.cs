namespace Prototype
{
    public class Square : Shape
    {
        public Square()
        {
            _type = "Square";
        }

        public override string draw()
        {
            return "Inside square draw() method";
        }
    }
}