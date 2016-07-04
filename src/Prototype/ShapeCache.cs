using System;
using System.Collections;

namespace Prototype
{
    public class ShapeCache
    {
        private static Hashtable shapeMap = new Hashtable();

        public static Shape getShape(
            string shapeId)
        {
            var cachedShape = (Shape)shapeMap[shapeId];

            throw new NotImplementedException();

            //return cachedShape.Clone();
        }

        public static void loadCache()
        {
            var circle = new Circle();

            circle.setId("1");
            shapeMap.Add(circle.getId(), circle);

            var square = new Square();

            square.setId("2");
            shapeMap.Add(square.getId(), square);

            var rectangle = new Rectangle();

            rectangle.setId("3");
            shapeMap.Add(rectangle.getId(), rectangle);
        }
    }
}