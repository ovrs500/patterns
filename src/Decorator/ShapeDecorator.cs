using System;

namespace Decorator
{
    public abstract class ShapeDecorator : IShape
    {
        protected IShape _decoratedShape;

        public ShapeDecorator(
            IShape decoratedShape)
        {
            _decoratedShape = decoratedShape;
        }

        public string draw()
        {
            return _decoratedShape.draw();
        }
    }
}