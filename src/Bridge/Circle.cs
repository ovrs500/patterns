using System;

namespace Bridge
{
    public class Circle : Shape
    {
        private int x;
        private int y;
        private int radius;

        public Circle(
            int x,
            int y,
            int radius,
            IDrawAPI drawAPI) : base(drawAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override string draw()
        {
            return drawAPI.drawCircle(radius, x, y);
        }
    }
}