using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public record Point3D
{
    public static Point3D Origin { get; set; } = new Point3D();
    public static Point3D FromOrigin(int x, int y, int z) => new Point3D { X = Origin.X + x, Y = Origin.Y + y, Z = Origin.Z + z };
    public static Point3D CreateX(int x) => new Point3D { X = x };
    public static Point3D CreateY(int y) => new Point3D { Y = y };
    public static Point3D CreateZ(int z) => new Point3D { Z = z };

    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    private Point3D() { }
}
