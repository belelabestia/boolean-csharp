using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Square : Rectangle, IEquilateral
{
    public Square(double side) : base(side, side)
    {
        Side = side;
    }

    public double Side { get; private init; }
}
