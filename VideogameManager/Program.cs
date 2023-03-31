using VideogameManager;

const string connectionString = "Data Source=localhost;Initial Catalog=VideogameDb;Integrated Security=True;Pooling=False";
var repo = new VideogameRepository(connectionString);

while (true)
{
    int opzione = 0;

    while (opzione is 0)
    {
        Console.WriteLine("Scegli una di queste opzioni:");
        Console.WriteLine("inserire un nuovo videogioco (1 o 'inserisci')");
        Console.WriteLine("ricercare un videogioco per id (2 o 'ricerca')");
        Console.WriteLine("ricercare tutti i videogiochi aventi il nome contenente una determinata stringa inserita in input (3 o 'filtra')");
        Console.WriteLine("eliminare un videogioco (4 o 'elimina')");
        Console.WriteLine("chiudere il programma (5 o 'chiudi')");

        var input = Console.ReadLine();

        opzione = identificaOpzione(input);
    }

    switch (opzione)
    {
        case 1:
            {
                Console.Write("Passa il nome: ");
                var name = Console.ReadLine() ?? "";

                Console.Write("Passa l'overview: ");
                var overview = Console.ReadLine() ?? "";

                Console.Write("Passa la release date (yyyy-MM-dd): ");
                var releaseDate = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Passa l'id della software house: ");
                var softwareHouseId = Convert.ToInt64(Console.ReadLine());

                var vg = new Videogame(0, name, overview, releaseDate, softwareHouseId);
                var success = repo.InsertVideogame(vg);

                if (success) Console.WriteLine("Videogioco inserito.");
                else Console.WriteLine("Inserimento fallito.");
            }
            break;
        case 2:
            {
                Console.Write("Passa l'id: ");

                var id = Convert.ToInt64(Console.ReadLine());
                var vg = repo.GetById(id);

                if (vg is null) Console.WriteLine("Videogame non trovato.");
                else Console.WriteLine(vg);
            }
            break;
        case 3:
            Console.WriteLine("Spiacente, feature non ancora implementata.");
            break;
        case 4:
            {
                Console.Write("Passa l'id: ");

                var id = Convert.ToInt64(Console.ReadLine());
                var success = repo.DeleteVideogame(id);

                if (success) Console.WriteLine("Videogioco eliminato.");
                else Console.WriteLine("Eliminazione fallita.");
            }
            break;
        case 5:
            Console.WriteLine("Esco.");
            return;
    }
}

int identificaOpzione(string? input)
{
    switch (input)
    {
        case "1":
        case "inserisci":
            return 1;
        case "2":
        case "ricerca":
            return 2;
        case "3":
        case "filtra":
            return 3;
        case "4":
        case "elimina":
            return 4;
        case "5":
        case "chiudi":
            return 5;
        default:
            Console.WriteLine("Input non valido.");
            return 0;
    }
}