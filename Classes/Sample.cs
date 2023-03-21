using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point() { }

    public Point(string x, string y)
    {
        X = Convert.ToInt32(x);
        Y = Convert.ToInt32(y);
    }

    public int Sum() => X + Y;

    public override string ToString() => $"[{X}, {Y}]";
}