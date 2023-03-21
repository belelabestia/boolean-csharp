using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// V creare classe Rectangle (base, height)
// V getArea, getPerimeter
// user input: base, height
// output: area, perimeter
// Rectangle:
// base: XXX cm
// height: XXX cm
// perim: XXX cm
// area: XXX cm2
// ToString() ->
// +-----+
// |     |
// |     |
// +-----+

public class Rectangle
{
    int _base;
    int _height;

    public Rectangle() { }

    public Rectangle(int Base, int Height)
    {
        this.Base = Base;
        this.Height = Height;
    }

    public int Base {
        get => _base == 0 ? 1 : _base;
        set
        {
            Console.WriteLine(value);

            if (value < 0)
            {
                throw new Exception();
            }

            _base = value;
        }
    }
    public int Height { get; set; }

    public int Area => Base * Height;
    public int Perimeter => (Base + Height) * 2;

    public override string ToString()
    {
        var nl = Environment.NewLine;

        return "Rectangle:" + nl
            + $"base: {Base} cm" + nl
            + $"height: {Height} cm" + nl
            + $"perimeter: {Perimeter} cm" + nl
            + $"area: {Area} cm2";
    }

    public string Draw()
    {
        var res = new StringBuilder();

        for (int row = 0; row < Height + 2; row++)
        {
            var line = new StringBuilder();

            for (int col = 0; col < Base + 2; col++)
            {
                if (
                    (row is 0 && col is 0) ||
                    (row is 0 && col == Base + 1) ||
                    (col is 0 && row == Height + 1) ||
                    (row == Height + 1 && col == Base + 1)
                )
                {
                    line.Append('+');
                }
                else
                {
                    if (row is 0 || row == Height + 1)
                    {
                        line.Append('-');
                    }

                    if (col is 0 || col == Base + 1)
                    {
                        line.Append('|');
                    }    
                    else if (row is not 0 && row != Height + 1)
                    {
                        line.Append(' ');
                    }
                }
            }

            res.AppendLine(line.ToString());
        }

        return res.ToString();
    }
}
