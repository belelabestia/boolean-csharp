using static System.Console;

namespace CibiPreferiti;

static class Alternativa
{
    public static void Main()
    {
        var cibiPreferiti = new[]
        {
            "Pizza",
            "Parmigiana",
            "Gelato",
            "Sushi",
            "Carbonara",
            "Pappa"
        };

        var isEven = cibiPreferiti.Length % 2 is 0;

        var midIndex = isEven
            ? cibiPreferiti.Length / 2
            : (cibiPreferiti.Length - 1) / 2;

        WriteLine("Elenco:");

        foreach (var cibo in cibiPreferiti) WriteLine(cibo);

        WriteLine();

        WriteLine("Lunghezza: " + cibiPreferiti.Length);
        WriteLine("Top: " + cibiPreferiti[0]);
        WriteLine("Non troppo: " + cibiPreferiti[^1]);

        var msg = isEven
            ? "Mediani: " + cibiPreferiti[midIndex - 1] + ", " + cibiPreferiti[midIndex]
            : "Mediano: " + cibiPreferiti[midIndex];

        WriteLine(msg);
    }
}
