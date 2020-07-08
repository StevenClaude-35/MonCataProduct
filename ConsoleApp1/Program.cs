using MonCataProduct.Models;
using System;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using(CatalogueDbContext context =new CatalogueDbContext())
            {
                context.Initialize(true);
                var produits = context.Produits.ToList();
            }
            Console.WriteLine("Ok");

        }
    }


}
