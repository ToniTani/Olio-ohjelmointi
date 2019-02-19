using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    class Rectangle : Shape
    {
        private readonly int length;
        private readonly int width;
        public Rectangle(int length, int width, string type, string color)
            : base(type, color)
        {
            this.length = length;
            this.width = width;
        }
        public override double GetArea()//'override' keyword
        {
            int area = this.length * this.width;
            return area;
        }
        public override string ToString()
        {
            return base.ToString() + $"\tLength: {length}\tWidht: {width}\tArea: {GetArea():F2}";
        }
    }
}