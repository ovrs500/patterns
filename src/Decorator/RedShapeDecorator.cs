using System;
using System.Text;

namespace Decorator
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(
            IShape decoratedShape) : base(decoratedShape)
        {
        }

        public new string draw()
        {
            var output = new StringBuilder();

            output.Append(_decoratedShape.draw());
            output.Append(Environment.NewLine);
            output.Append(setRedBorder(_decoratedShape));

            return output.ToString();
        }

        private string setRedBorder(
            IShape decoratedShape)
        {
            var change = "asdfsaf";
            var newchagne = "asdfs";

            return "Border Color: Red";
        }
    }
}