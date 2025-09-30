using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Rectangle
    {
        private double length;
        private double width;
        public void Set(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double GetArea()
        {
            return length * width;
        }
        public double GetPerimeter()
        {
            return (length + width) * 2;
        }
    }
}
