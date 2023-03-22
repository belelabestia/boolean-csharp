using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NonZeroPoint
{
    private int x;
    private int y;

    public NonZeroPoint(int x, int y)
    {
        if (x == 0 && y == 0) throw new ArgumentException();

        this.x = x;
        this.y = y;
    }

    public NonZeroPoint(string x, string y) : this(Convert.ToInt32(x), Convert.ToInt32(y)) { }

    public int X
    {
        get { return x; }
        set
        {
            SetX(value);
        }
    }

    public int Y
    {
        get { return y; }
        set
        {
            SetY(value);
        }
    }

    public void SetX(int x)
    {
        if (x is 0) throw new ArgumentException();

        this.x = x;
    }

    public int GetX() => x;

    public void SetY(int y)
    {
        if (y is 0) throw new ArgumentException();

        this.y = y;
    }

    public int GetY() => y;

    public int Sum() => x + y;

    public override string ToString() => $"[{x}, {y}]";
}