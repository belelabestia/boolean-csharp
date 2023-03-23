using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rectangle : IPolygon
{
    readonly double @base;
    readonly double height;

    public Rectangle(double @base, double height)
    {
        this.@base = @base;
        this.height = height;
    }

    public int TotalAngleDegrees => 360;
    public double GetArea() => @base * height;
    public double GetPerimeter() => (@base + height) * 2;
}
