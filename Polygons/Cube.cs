using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cube : IEquilateral
{
    public Cube(double side)
    {
        Side = side;
    }
    public double Side { get; private init; }
}

