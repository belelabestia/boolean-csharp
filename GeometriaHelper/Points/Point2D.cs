using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public record Point2D
{
    public static Point2D Origin { get; set; } = new Point2D();
    public static Point2D FromOrigin(int x, int y) => new Point2D { X = Origin.X + x, Y = Origin.Y + y };
    public static Point2D CreateX(int x) => new Point2D { X = x };
    public static Point2D CreateY(int y) => new Point2D { Y = y };
    public int X { get; set; }
    public int Y { get; set; }

    private Point2D() { }
}
