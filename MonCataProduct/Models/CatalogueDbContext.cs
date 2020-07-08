using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonCataProduct.Models
{
    public class CatalogueDbContext:DbContext 
    {
       public DbSet<Produit> Produits { get; set; }
        public DbSet<Categorie> Categories { get; set; }

        public CatalogueDbContext():base()
        {

        }
        public CatalogueDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Inital Catalog = CatalDb ; Integrated Security=true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>()
                .HasMany(c => c.Produits)
                .WithOne(p => p.Categorie);
            base.OnModelCreating(modelBuilder);
                
        }
    }
}
