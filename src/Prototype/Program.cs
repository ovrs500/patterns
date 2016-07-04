using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeCache.loadCache();

            var clonedShape1 = (Shape)ShapeCache.getShape("1");
            var clonedShape2 = (Shape)ShapeCache.getShape("2");
            var clonedShape3 = (Shape)ShapeCache.getShape("3");

            Console.WriteLine("Shape: 1" + clonedShape1.getType());
            Console.WriteLine("Shape: 2" + clonedShape2.getType());
            Console.WriteLine("Shape: 3" + clonedShape3.getType());
            Console.ReadLine();
        }
    }
}