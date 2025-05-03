using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assin1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Rectangle rect = new Rectangle(5, 10);

            int area1 = rect.CalculateArea();

            int area2 = rect.CalculateArea(7, 3);

            Console.WriteLine("Area using object fields: " + area1);
            Console.WriteLine("Area using parameters: " + area2);*/
            /*Calculator calc = new Calculator();

            int sumTwo = calc.Add(5, 10);         
            int sumThree = calc.Add(5, 10, 15);   

            Console.WriteLine("Sum of two numbers: " + sumTwo);
            Console.WriteLine("Sum of three numbers: " + sumThree);*/
            /*3- Person person = new Person("Alice", 30);

             person.PrintInfo();

             person.PrintInfo(3);*/
            /*4- Product product = new Product("Laptop", 1200.50, 3);

            double totalCost1 = product.CalculateTotalCost();
            Console.WriteLine($"Total cost (instance values): {totalCost1}");

            double totalCost2 = product.CalculateTotalCost(1100.75, 4);
            Console.WriteLine($"Total cost (passed values): {totalCost2}"); */

             Employee emp = new Employee("Alice", 30, 75000);

             emp.PrintDetails();

             Console.WriteLine();

             emp.PrintDetails(3);
        }
    }
}
