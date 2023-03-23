var rec = new Rectangle(2, 5);
var sq = new Square(5);
var tri = new Triangle(3, 4, 4, 5);
var cube = new Cube(4);
var maybeEqTri = new Triangle(1, 0, 1, maybeOneMaybeTwo());
var eqTri = new EquilateralTriangle(3);

var pols = new List<IPolygon> { rec, sq, tri, eqTri };
var eqs = new List<IEquilateral> { sq, cube, eqTri };

if (EquilateralTriangle.FromTriangle(maybeEqTri) is IEquilateral ie) eqs.Add(ie);

foreach (var p in pols)
{
    Console.WriteLine(p.TotalAngleDegrees);
    Console.WriteLine(p.GetPerimeter());
    Console.WriteLine(p.GetArea());

    if (p is Triangle t) Console.WriteLine(t.Sides);
}

Console.WriteLine("--------------------------------------");

foreach (var eq in eqs)
{
    Console.WriteLine(eq.Side);
}

int maybeOneMaybeTwo()
{
    var ran = new Random();
    return ran.Next(1, 3);
}