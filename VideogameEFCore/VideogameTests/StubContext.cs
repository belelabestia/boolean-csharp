using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VideogameEFCore.Models;

namespace VideogameTests
{
    public class StubContext : VideogameContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseInMemoryDatabase("test_db");
        }
    }
}
