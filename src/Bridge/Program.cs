using System;namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var redCircle = new Circle(100, 100, 10, new RedCircle());
            var greenCircle = new Circle(100, 100, 10, new GreenCircle());

            Console.WriteLine(redCircle.draw());
            Console.WriteLine(greenCircle.draw());
            Console.ReadLine();
        }
    }
}