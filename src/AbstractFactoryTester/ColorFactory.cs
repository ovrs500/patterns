using System;

namespace AbstractFactoryTester
{
    public class ColorFactory : AbstractFactory
    {
        public override IColor getColor(string color)
        {
            if (string.IsNullOrWhiteSpace(color))
            {
                return null;
            }

            if (color.ToLower() == "red")
            {
                return new Red();
            }

            if (color.ToLower() == "green")
            {
                return new Green();
            }

            if (color.ToLower() == "blue")
            {
                return new Blue();
            }

            return null;
        }

        public override IShape getShape(string shape)
        {
            return null;
        }
    }
}