using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    class Circle : Shape
    {
        private readonly double radius;
        public Circle(double r, string type, string color)
            : base(type, color)
        {
            this.radius = r;
        }
        public override double GetArea()
        {
            int area = (int)(Math.Pow(this.radius, 2) * Math.PI);
            return area;
        }
        public override string ToString()
        {
            return base.ToString() + $"\tRadius: {radius}\tArea: {GetArea():F2}\t";
        }
    }
}
