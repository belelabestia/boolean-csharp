using GestoreEventi;

Console.WriteLine("Inserisci un nuovo evento:");

Console.WriteLine("Titolo evento:");
string titolo = Console.ReadLine()!;

Console.WriteLine("Data evento:");
DateTime data = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("Capienza massima:");
int capienzaMax = Convert.ToInt32(Console.ReadLine());

var evento = new Evento(titolo, data, capienzaMax);

Console.WriteLine("Vuoi fare prenotazioni? (0 = no, altrimenti specificare numero)");
int prenotazioni = Convert.ToInt32(Console.ReadLine());

evento.PrenotaPosti(prenotazioni);

Console.WriteLine($"Posti prenotati: {evento.PostiPrenotati}; posti disponibili: {evento.PostiDisponibili}.");

while (true)
{
    Console.WriteLine("Vuoi disdire dei posti? (sì/no; default no)");

    var input = Console.ReadLine();

    if (input == "sì")
    {
        Console.WriteLine("Quanti posti vuoi disdire?");
        int postiDaDisdire = Convert.ToInt32(Console.ReadLine());

        evento.DisdiciPosti(postiDaDisdire);
    }
    else
    {
        Console.WriteLine("Ok va bene!");
        break;
    }
}