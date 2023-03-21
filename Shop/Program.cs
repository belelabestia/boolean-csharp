var p = new Product("Libro")
{
    Price = 100,
    Iva = 0.22,
    Description = "Un bel libro da leggere.",
};

Console.WriteLine(p);
Console.WriteLine($"price after iva: {p.GetPriceAfterIva()}; extended name: {p.GetExtendedName()}.");