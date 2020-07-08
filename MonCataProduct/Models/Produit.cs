using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MonCataProduct.Models
{
    [Table("PRODUITS")]
    public class Produit
    {
        [Key]
        public int ProduitID { get; set; }
        [StringLength(70)]
        public string Designation { get; set; }
        public double Prix { get; set; }
        public int Quantite { get; set; }
        public int CategorieID { get; set; }
        public virtual Categorie Categorie { get; set; }
    }
}
