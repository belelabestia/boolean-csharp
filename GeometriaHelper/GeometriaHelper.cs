using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class GeometriaHelper
{
    public static double AreaRettangolo(double @base, double altezza) => @base * altezza;
    public static double AreaTriangolo(double @base, double altezza) => @base * altezza / 2;
    public static double PerimetroRettangolo(double @base, double altezza) => (@base + altezza) * 2;
    public static double PerimetroTriangolo(double lato1, double lato2, double lato3) => lato1 + lato2 + lato3;
}
