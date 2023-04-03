using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VideogameEFCore.Models;

namespace VideogameEFCore
{
    public static class VideogameManager
    {
        public static void InserisciVideogame(Videogame videogame)
        {
            using var db = new VideogameContext();

            db.Videogames.Add(videogame);
            db.SaveChanges();
        }

        public static Videogame? CercaVideogamePerId(long id)
        {
            using var db = new VideogameContext();

            return db.Videogames
                .Include(v => v.SoftwareHouse)
                .First(v => v.Id == id);
        }

        public static List<Videogame> CercaVideogamePerNome(string nome)
        {
            using var db = new VideogameContext();
            return db.Videogames.Where(v => v.Name.Contains(nome)).ToList();
        }

        public static void CancellaVideogioco(long id)
        {
            using var db = new VideogameContext();

            var vg = db.Videogames.Find(id);

            if (vg is null) return;

            db.Videogames.Remove(vg);
            db.SaveChanges();
        }

        public static long InserisciSoftwareHouse(SoftwareHouse softwareHouse)
        {
            using var db = new VideogameContext();

            db.SoftwareHouses.Add(softwareHouse);
            db.SaveChanges();

            return softwareHouse.Id;
        }
    }
}
