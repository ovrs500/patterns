using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var ceo = new Employee("John", "CEO", 30000);
            var headSales = new Employee("Robert", "Head Sales", 20000);
            var headMarketing = new Employee("Micheal", "Head Marketing", 20000);
            var clerk1 = new Employee("Laura", "Marketing", 10000);
            var clerk2 = new Employee("Bob", "Marketing", 10000);
            var salesExec1 = new Employee("Richard", "Sales", 10000);
            var salesExec2 = new Employee("Rob", "Sales", 10000);

            ceo.add(headSales);
            ceo.add(headMarketing);
            headSales.add(salesExec1);
            headSales.add(salesExec2);
            headMarketing.add(clerk1);
            headMarketing.add(clerk2);

            Console.WriteLine(ceo.toString());

            foreach (var heademployee in ceo.getSubordinates())
            {
                Console.WriteLine(heademployee.toString());

                foreach (var employee in heademployee.getSubordinates())
                {
                    Console.WriteLine(employee.toString());
                }
            }

            Console.ReadLine();
        }
    }
}