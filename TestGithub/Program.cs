using static System.Console;
using static System.Convert;

WriteLine("Inserisci il titolo: ");
string? titolo = ReadLine();

WriteLine("Inserisci l'autore: ");
string? autore = ReadLine();

WriteLine("Inserisci ISBN: ");
string? ISBN = ReadLine();

WriteLine("Inserisci il numero di pagine: ");
int numeroPagine = ToInt32(ReadLine());

WriteLine("Inserisci peso in chili: ");
double pesoKg = ToDouble(ReadLine());

WriteLine("Inserisci il valutazione media: ");
double valutazioneMediaSu5 = ToDouble(ReadLine());

WriteLine("Inserisci il numero di recensioni: ");
int numeroRecensioni = ToInt32(ReadLine());

WriteLine("Inserisci disponibilità kindle (s/N): ");
bool disponibileKindle = (ReadLine() ?? "") == "s";

WriteLine("Inserisci disponibilità cop. flessibile (s/N): ");
bool disponibileCopertinaFlessibile = (ReadLine() ?? "") == "s";

WriteLine($"——— IL LIBRO DI OGGI: {titolo} di {autore} ———");
WriteLine("Informazioni generiche:");
WriteLine("ISBN: {0}", ISBN);
WriteLine("Numero pagine: {0}", numeroPagine);
WriteLine("Peso (kg): {0}", pesoKg);
WriteLine("Valutazione media: {0}", valutazioneMediaSu5);
WriteLine("numero recensioni: {0}", numeroRecensioni);
WriteLine($"Disponibile su Kindle: {(disponibileKindle ? "sì" : "no")}");
WriteLine("Disponibile in cop. flessibile: {0}", disponibileCopertinaFlessibile ? "sì" : "no");
