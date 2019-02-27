using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    class Triangle : Shape // a subclass called Triangle with its own unique characteristics, it inherits from Shape
    {
        private readonly int baseLenght;
        private readonly int height;
        public Triangle(int baseLenght, int height, string type, string color)
            : base(type, color)
        {
            this.baseLenght = baseLenght;
            this.height = height;
        }
        public override double GetArea()
        {
            int area = this.baseLenght * this.height / 2;
            return area;
        }
        public override string ToString()
        {
            return base.ToString() + $"\tBaselength: {baseLenght}\tHeight: {height}\tArea: {GetArea():F2}\t";
        }

    }
}
