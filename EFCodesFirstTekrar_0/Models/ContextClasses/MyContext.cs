using EFCodesFirstTekrar_0.Configurations;
using EFCodesFirstTekrar_0.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodesFirstTekrar_0.Models.ContextClasses
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new BransConfiguration());
            modelBuilder.Configurations.Add(new EgitmenConfiguration());
            modelBuilder.Configurations.Add(new DersConfiguration());
            modelBuilder.Configurations.Add(new EgitmenBransConfiguration());
            modelBuilder.Configurations.Add(new OgrenciConfiguration());
            modelBuilder.Configurations.Add(new OgrenciDersConfiguration());
            modelBuilder.Configurations.Add(new DanismanConfiguration());
            modelBuilder.Configurations.Add(new LabConfiguration());


        }

        public DbSet<Brans> Branslar { get; set; }
        public DbSet<Egitmen> Egitmenler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<EgitmenBrans> EgitmenBranslari { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<OgrenciDers> OgrenciDersleri { get; set; }
        public DbSet<Danisman> Danismanlar { get; set; }
        public DbSet<Lab> Lablar { get; set; }












    }
}
