using Ders2.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders2.Contexts
{
    public class OkulDBContext:DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }
        public DbSet<Adres> Adresler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.; Database=OkulDB;Trusted_Connection=True; TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adres>().HasKey(adres=>adres.Id);
            modelBuilder.Entity<Ogrenci>().HasOne(ogrenci=>ogrenci.Adres).WithOne(adress=>adress.Ogrenci).HasForeignKey<Adres>(adres=>adres.Id);
            
        }
    }
}
