using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assin1
{
    internal class Employee
    {
        private string name;
        private int age;
        private double salary;

        public Employee(string name, int age, double salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary:C}");
        }

        public void PrintDetails(int times)
        {
            for (int i = 0; i < times; i++)
            {
                PrintDetails();
            }
        }
    }
}
