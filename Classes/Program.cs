var p1 = new Point(0, 0);
var pp1 = p1;
var p2 = new Point("0", "0");
var p3 = new Point();

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);

p1 = null;
p2 = null;

{
    var a = new Point();

    Console.WriteLine(a);
}