using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UtilityCar : Car
{
    public UtilityCar(string name, int doorCount, int maxSpeed) : base(name, doorCount, maxSpeed) { }
    public override string GetName() => "(utility car) " + name;
    public void Tow() => Console.WriteLine("Towing another car...");
}
