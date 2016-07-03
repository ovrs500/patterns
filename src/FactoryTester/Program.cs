using FactoryTester.Factory;
using System;

namespace FactoryTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = new ShapeFactory();
            var circle = shapeFactory.getShape("circle");
            var square = shapeFactory.getShape("square");
            var rectangle = shapeFactory.getShape("rectangle");

            Console.WriteLine(circle.Draw());
            Console.WriteLine(square.Draw());
            Console.WriteLine(rectangle.Draw());
            Console.ReadLine();
        }
    }
}