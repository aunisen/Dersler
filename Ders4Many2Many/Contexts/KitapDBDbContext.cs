using Ders4Many2Many.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders4Many2Many.Contexts
{
    public class KitapDBDbContext:DbContext
    {
        public DbSet<Entites.Kitap> Kitaplar { get; set; }
        public DbSet<Entites.Yazar> Yazarlar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=KitapDB;Trusted_Connection=True; TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entites.KitapYazar>().HasKey(x => new { x.KitapId, x.YazarId });
            modelBuilder.Entity<KitapYazar>().HasOne(ky => ky.Kitap).WithMany(k => k.KitapYazarlar).HasForeignKey(fk=>fk.KitapId);
            modelBuilder.Entity<KitapYazar>().HasOne(ky => ky.Yazar).WithMany(y => y.YazarKitaplar).HasForeignKey(fk=>fk.YazarId);
            
        }
    }
}
