using CibiPreferiti;

string[] cibiPreferiti =
{
    "Pizza",
    "Parmigiana",
    "Gelato",
    "Sushi",
    "Carbonara",
    "Pappa"
};

bool isEven = cibiPreferiti.Length % 2 == 0;

int midIndex;

if (isEven)
{
    midIndex = cibiPreferiti.Length / 2;
}
else
{
    midIndex = (cibiPreferiti.Length - 1) / 2;
}

Console.WriteLine("Elenco:");

for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(cibiPreferiti[i]);
}

Console.WriteLine();

Console.WriteLine("Lunghezza: " + cibiPreferiti.Length);
Console.WriteLine("Top: " + cibiPreferiti[0]);
Console.WriteLine("Non troppo: " + cibiPreferiti[^1]);

if (isEven)
{
    Console.WriteLine("Mediani: " + cibiPreferiti[midIndex - 1] + ", " + cibiPreferiti[midIndex]);
}
else
{
    Console.WriteLine("Mediano: " + cibiPreferiti[midIndex]);
}

Console.WriteLine("--------------");

Alternativa.Main();

