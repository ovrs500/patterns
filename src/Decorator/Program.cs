using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            var redCircle = new RedShapeDecorator(new Circle());
            var redRectangle = new RedShapeDecorator(new Rectangle());

            Console.WriteLine("Circle with normal border");
            Console.WriteLine(circle.draw());
            Console.WriteLine("Circle with red border");
            Console.WriteLine(redCircle.draw());
            Console.WriteLine("Rectangle with red border");
            Console.WriteLine(redRectangle.draw());
            Console.ReadLine();
        }
    }
}