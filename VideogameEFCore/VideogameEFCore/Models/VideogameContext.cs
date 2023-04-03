using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VideogameEFCore.Models
{
    public class VideogameContext : DbContext
    {
        public DbSet<Videogame> Videogames { get; set; }
        public DbSet<SoftwareHouse> SoftwareHouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=localhost;Initial Catalog=EFVideogames;Integrated Security=True;Pooling=False;TrustServerCertificate=True");
        }
    }
}
