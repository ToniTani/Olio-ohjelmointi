using System;
using System.Collections.Generic;

namespace Polygon
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the list of shapes!");
            Console.WriteLine("-------------");

            //Objects of type shape and initialised with a specific information
            Shape rectangle = new Rectangle( 15, 10, "Rectangle", "White");
            Shape triangle = new Triangle(10, 20, "Triangle ", "Black");
            Shape circle = new Circle(6, "Circle   ", "Pink");

            List<Shape> shapeList = new List<Shape>();

            shapeList.Add(circle);
            shapeList.Add(triangle);
            shapeList.Add(rectangle);
            shapeList.Add(circle);
            shapeList.Add(rectangle);
            shapeList.Add(triangle);

            foreach (var Shape in shapeList)
            {
                Shape.GetInfo();
            }

            Console.WriteLine("-------------");
            // Picking up the rectangles from the list.
            Console.WriteLine("Rectangles only:\n");
            foreach (var type in shapeList)
            {
                if (type is Rectangle)
                    Console.WriteLine(type.ToString());
            }

            // write out the areas of the shapes created
            //Console.WriteLine("Area of square: {0} units", rectangle.GetArea());
            //Console.WriteLine("Area of triangle: {0} units", triangle.GetArea());
            //Console.WriteLine("Area of circle: {0} units", circle.GetArea());

            Console.ReadLine();
        }
    }
}