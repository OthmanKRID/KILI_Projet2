﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kili.Models.Vente
{
    public class Catalogue
    {
            [ScaffoldColumn(false)]
            public int CatalogueID { get; set; }

            [Required, StringLength(100), Display(Name = "Catalogue")]
            public string CatalogueName { get; set; }

            [Display(Name = "Déscription")]
            public string Description { get; set; }

            public virtual ICollection<Produit> Produits { get; set; }
        }
    }
