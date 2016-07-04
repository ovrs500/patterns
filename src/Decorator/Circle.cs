using System;

namespace Decorator
{
    public class Circle : IShape
    {
        public string draw()
        {
            return "Shape: Circle";
        }
    }
}