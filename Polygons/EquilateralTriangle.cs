using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EquilateralTriangle : Triangle, IEquilateral
{
    public static EquilateralTriangle? FromTriangle(Triangle triangle)
    {
        var (s1, s2, s3) = triangle.Sides;

        return (s1 == s2 && s2 == s3)
            ? new EquilateralTriangle(s1)
            : null;
    }

    public EquilateralTriangle(double side) : base(side, side, side, side) 
    {
        Side = side;
    }

    public double Side { get; private init; }
}

