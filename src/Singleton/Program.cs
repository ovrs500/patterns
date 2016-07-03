using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = SingleObject.getInstance();

            Console.WriteLine(obj.ShowMessage());
            Console.ReadLine();
        }
    }
}