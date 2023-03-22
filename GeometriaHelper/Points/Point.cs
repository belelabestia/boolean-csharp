using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Point
{
    public static Point3D ToPoint3D(this Point2D point) => Point3D.FromOrigin(point.X, point.Y, 0);
    public static Point2D ToPoint2D(this Point3D point) => Point2D.FromOrigin(point.X, point.Y);
}
