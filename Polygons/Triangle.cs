using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Triangle : IPolygon
{
    readonly double @base;
    readonly double height;
    readonly double side2;
    readonly double side3;

    public Triangle(double @base, double height, double side2, double side3)
    {
        this.@base = @base;
        this.height = height;
        this.side2 = side2;
        this.side3 = side3;
    }

    public (double, double, double) Sides => (@base, side2, side3);
    public int TotalAngleDegrees => 180;
    public double GetArea() => (@base * height) / 2;
    public double GetPerimeter() => @base + side2 + side3;
}
