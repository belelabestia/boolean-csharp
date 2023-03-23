using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IPolygon
{
    int TotalAngleDegrees { get; }
    double GetPerimeter();
    double GetArea();
}
