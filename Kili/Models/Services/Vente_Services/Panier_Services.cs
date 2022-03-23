using Kili.Models.Vente;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kili.Models.Services.Vente_Services
{
    public class Panier_Services
    {
        private BddContext _bddContext;
        public Panier_Services()
        {
            _bddContext = new BddContext();
        }
        
        //Fonction permettant d'obtenir la liste de tous les paniers
        /*public List<Panier>ObtenirAllPaniers()
        {
            return _bddContext.Paniers
        }*/
    }
}
