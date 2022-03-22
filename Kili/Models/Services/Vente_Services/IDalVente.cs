using System;
using System.Collections.Generic;
using Kili.Models.Vente;

namespace Kili.Models.Services.Vente_Services
{
    public interface IDalVente : IDisposable
    {
        void DeleteCreateDatabase();

        // CATALOGUE
        List<Catalogue> ObtientAllCatalogues();

        int CreerCatalogue(string catalogueName, string description);

        void ModifierCatalogue(Catalogue catalogue);

        void SupprimerCatalogue(int catalogueid);

        //PRODUIT

        List<Produit> ObtientAllProduits();

        int CreerProduit(string designation, string format, string description, string imagePath, double prixUnitaire, string devise, int catalogueid);
        void ModifierProduit(Produit produit);
        void SupprimerProduit(int produitid);
    }
}
