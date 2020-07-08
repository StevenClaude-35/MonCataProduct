using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonCataProduct.Models
{
    public static class CatalogueInitializer
    {
        public static void Initialize(this CatalogueDbContext context,bool dropAlways = false)
        {
            
           

            var categories = new List<Categorie>()
            {
                new Categorie()
                {
                    NomCategorie="Ordinateurs"
                },
                new Categorie()
                {
                    NomCategorie="Smartphones"
                },
                new Categorie()
                {
                    NomCategorie="Imprimantes"
                },
            };
            var produits = new List<Produit>()
            {
                new Produit()
                {
                    Designation="HP 65 90",
                    Prix=7800,
                    Quantite=6,
                    CategorieID=1
                },
                 new Produit()
                {
                    Designation="Samsumg",
                    Prix=5000,
                    Quantite=12,
                    CategorieID=2
                },
                  new Produit()
                {
                    Designation="Node Book Pro",
                    Prix=7600,
                    Quantite=11,
                    CategorieID=1
                },
                   new Produit()
                {
                    Designation="Epson 54690",
                    Prix=1200,
                    Quantite=6,
                    CategorieID=3
                },
            };

            context.Categories.AddRange(categories);
            context.Produits.AddRange(produits);

            context.SaveChanges();

        }
    }
}
