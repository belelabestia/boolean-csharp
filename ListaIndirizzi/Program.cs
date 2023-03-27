using ListaIndirizzi;

var addresses = Parser.Read();

foreach (var address in addresses)
{
    Console.WriteLine(address);
}