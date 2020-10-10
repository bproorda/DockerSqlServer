using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DockerSqlServer.Models;

namespace DockerSqlServer.Data
{
    public class MagContext : DbContext
    {
        public MagContext (DbContextOptions<MagContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Magazine>().HasData(
            new Magazine { MagazineId = 1, Name = "MSDN Magazine" },
            new Magazine { MagazineId = 2, Name = "Docker Magazine" },
            new Magazine { MagazineId = 3, Name = "EFCore Magazine" }
            );
        }

        public DbSet<DockerSqlServer.Models.Magazine> Magazine { get; set; }
    }
}
