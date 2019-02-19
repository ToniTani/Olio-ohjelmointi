using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{ }
abstract class Shape //this abstract Shape class is the base class to other classes
{
    public abstract double GetArea();

    public string Type { get; set; }
    public string Color { get; set; }

    protected Shape(string type, string color)
    {
        Type = type;
        Color = color;
    }

    public string GetColor()
    {
        return this.Color;
    }

    public override string ToString()
    {
        return $"Shape: {Type}\tColor: {Color}\t";
    }
    public void GetInfo()
    {
        Console.WriteLine(ToString());
    }
}