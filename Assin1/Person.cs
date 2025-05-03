using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assin1
{
    internal class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        public void PrintInfo(int times)
        {
            for (int i = 0; i < times; i++)
            {

                Console.WriteLine($"Name: {name}, Age: {age}");
            }
        }
    }
}
