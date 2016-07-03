using System;

namespace AbstractFactoryTester
{
    class Program
    {
        static void Main(string[] args)
        {
            // get shape factory
            var shapeFactory = FactoryProducer.getFactory("shape");
            var colorFactory = FactoryProducer.getFactory("color");
            var circle = shapeFactory.getShape("circle");
            var rectangle = shapeFactory.getShape("rectangle");
            var square = shapeFactory.getShape("square");
            var red = colorFactory.getColor("red");
            var blue = colorFactory.getColor("blue");
            var green = colorFactory.getColor("green");

            Console.WriteLine(circle.Draw());
            Console.WriteLine(square.Draw());
            Console.WriteLine(rectangle.Draw());
            Console.WriteLine(red.Fill());
            Console.WriteLine(green.Fill());
            Console.WriteLine(blue.Fill());
            Console.ReadLine();
        }
    }
}