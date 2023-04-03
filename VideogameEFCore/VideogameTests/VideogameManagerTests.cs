using Microsoft.VisualStudio.CodeCoverage;
using VideogameEFCore;
using VideogameEFCore.Models;

namespace VideogameTests
{
    public class VideogameManagerTests
    {
        VideogameManager _manager;
        StubContext _stubContext;

        [SetUp]
        public void Setup()
        {
            _stubContext = new StubContext();
            _stubContext.Database.EnsureDeleted();
            _manager = new VideogameManager(_stubContext);
        }

        [TearDown]
        public void Clean()
        {
            _stubContext.Dispose();
        }

        [Test]
        public void InserisciVideogame_DoesNotThrow()
        {
            var ninendo = new SoftwareHouse
            {
                Name = "Nintendo",
                City = "Tokyo",
                Country = "Giappone",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            var shId = _manager.InserisciSoftwareHouse(ninendo);

            var marioKart = new Videogame
            {
                Name = "Super Mario Kart",
                Overview = "Arcade racing game",
                SoftwareHouseId = shId,
                ReleaseDate = new DateTime(2000, 01, 01),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            Assert.DoesNotThrow(() => _manager.InserisciVideogame(marioKart));
            Assert.That(_stubContext.Videogames.Count(), Is.EqualTo(1));
        }

        [Test]
        public void CercaVideogamePerId_ReturnsIfFound()
        {

        }

        [Test]
        public void CercaVideogamePerId_ReturnsNullIfNotFound()
        {

        }
    }
}