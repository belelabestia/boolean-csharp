using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Microsoft.EntityFrameworkCore;
using VideogameEFCore.Models;

namespace VideogameEFCore
{
    public class VideogameManager
    {
        VideogameContext context;

        public VideogameManager(VideogameContext context)
        {
            this.context = context;
        }

        public void InserisciVideogame(Videogame videogame)
        {
            context.Videogames.Add(videogame);
            context.SaveChanges();
        }

        public Videogame? CercaVideogamePerId(long id)
        {
            return context.Videogames
                .Include(v => v.SoftwareHouse)
                .First(v => v.Id == id);
        }

        public List<Videogame> CercaVideogamePerNome(string nome)
        {
            return context.Videogames.Where(v => v.Name.Contains(nome)).ToList();
        }

        public void CancellaVideogioco(long id)
        {
            var vg = context.Videogames.Find(id);

            if (vg is null) return;

            context.Videogames.Remove(vg);
            context.SaveChanges();
        }

        public long InserisciSoftwareHouse(SoftwareHouse softwareHouse)
        {
            context.SoftwareHouses.Add(softwareHouse);
            context.SaveChanges();

            return softwareHouse.Id;
        }
    }
}
