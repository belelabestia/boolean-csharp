Point2D.Origin = Point2D.FromOrigin(3, 3);
Point3D.Origin = Point3D.FromOrigin(11, 1, 1);

var px = Point2D.CreateX(4);
var py = Point2D.CreateY(45);
var o = Point2D.Origin;
var fo = Point2D.FromOrigin(3, 4);

var p3d = Point3D.CreateX(2);
var p2d = Point.ToPoint2D(p3d);

p3d.ToPoint2D();

Console.WriteLine(fo);