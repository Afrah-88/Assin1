using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assin1
{
    internal class Rectangle
    {
        private int length;
        private int width;

        public Rectangle(int length, int width)

        {
            this.length = length;
            this.width = width;
        }

        public int CalculateArea()
        {
            return length * width;
        }

        public int CalculateArea(int length, int width)
        {
            return length * width;
        }
    }
}
