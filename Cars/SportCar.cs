using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SportCar : Car
{
    public SportCar(string name, int doorCount, int maxSpeed) : base(name, doorCount, maxSpeed) { }
    public override string GetName() => "(sport car) " + name;
    public void TurnOnTurbo() => Console.WriteLine("Turbo on!");
}
