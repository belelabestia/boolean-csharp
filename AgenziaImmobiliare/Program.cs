var db = new List<Immobile>();

db.Add(new Box("ccccc", "via vvvv", "002020", "mi", 23, 3, 2));
db.Add(new Abitazione("ccccc", "via vvvv", "002020", "mi", 23, 3, 2, 4));

Console.WriteLine("Gestionale agenzia immobiliare");

// main loop
while (true)
{
    Console.WriteLine("leggi | cerca | inserisci");

    var instruction = Console.ReadLine();

    switch (instruction)
    {
        case "leggi":
            foreach (var imm in db)
            {
                Console.WriteLine(imm);
            }
            break;
        case "cerca":
            break;
        case "inserisci":
            break;
        default:
            break;
    }
}
