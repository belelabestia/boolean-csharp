var prod = new Product("Libro")
{
    Price = 100,
    Iva = 0.22,
    Description = "Un bel libro da leggere.",
};

var person = new Person("Anna", "Rossi");

Console.WriteLine(prod);
Console.WriteLine($"price after iva: {prod.GetPriceAfterIva()}; extended name: {prod.GetExtendedName()}.");

printExtended(prod);
printExtended(person);

void printExtended(IHasExtendedName hasExtendedName)
{
    var ext = hasExtendedName.GetExtendedName();
    Console.WriteLine(ext);
}