using VideogameEFCore;
using VideogameEFCore.Models;

var ninendo = new SoftwareHouse
{
    Name = "Nintendo",
    City = "Tokyo",
    Country = "Giappone",
    CreatedAt = DateTime.Now,
    UpdatedAt = DateTime.Now,
};

var shId = VideogameManager.InserisciSoftwareHouse(ninendo);

var marioKart = new Videogame
{
    Name = "Super Mario Kart",
    Overview = "Arcade racing game",
    SoftwareHouseId = shId,
    ReleaseDate = new DateTime(2000, 01, 01),
    CreatedAt = DateTime.Now,
    UpdatedAt = DateTime.Now,
};

var mario64 = new Videogame
{
    Name = "Super Mario 64",
    Overview = "3d platform game",
    SoftwareHouseId = shId,
    ReleaseDate = new DateTime(1996, 01, 01),
    CreatedAt = DateTime.Now,
    UpdatedAt = DateTime.Now,
};

VideogameManager.InserisciVideogame(marioKart);
VideogameManager.InserisciVideogame(mario64);

var results = VideogameManager.CercaVideogamePerNome("Mario Kart");

var vg = results.First();
var vgById = VideogameManager.CercaVideogamePerId(vg.Id);

if (vgById is null)
{
    Console.WriteLine("Videogame not found by Id.");
    return;
}

Console.WriteLine($"vg: {vg.Name}");
Console.WriteLine($"vgById: {vgById.Name}");
Console.WriteLine($"vg software house: {vgById.SoftwareHouse!.Name}");

VideogameManager.CancellaVideogioco(vgById.Id);

