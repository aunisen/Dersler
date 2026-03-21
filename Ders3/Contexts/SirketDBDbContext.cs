using Ders3.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders3.Contexts
{
    public class SirketDBDbContext:DbContext
    {
        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet<Departman> Departmanlar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=SirketDB;Trusted_Connection=True; TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Calisan>().HasOne(c => c.Departman).WithMany(d => d.Calisanlar).HasForeignKey(c => c.DepartmanId);
        }
    }
}
