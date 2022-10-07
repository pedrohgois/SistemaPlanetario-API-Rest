using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaSolarAPI.Entities;

namespace SistemaSolarAPI.Data
{
    public class SistemaSolarAPIContext : DbContext
    {
        public SistemaSolarAPIContext (DbContextOptions<SistemaSolarAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Planeta> Planeta { get; set; } = default!;

        public DbSet<SistemaSolar> SistemaSolar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlanetaMap());
            modelBuilder.ApplyConfiguration(new SistemaSolarMap());
        }
    }
}
