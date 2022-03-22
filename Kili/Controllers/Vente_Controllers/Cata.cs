using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Kili.Models.Services.Vente_Services;
using Kili.Models.Vente;

namespace Kili.Controllers.Vente_Controllers
{
    public class Cata : Controller
    {
        private Catalogue_Services _Catalogue_Services;
        public Cata()
        {
            _Catalogue_Services = new Catalogue_Services();
        }

        public IActionResult Index()
        {
            Catalogue_Services catservice = new Catalogue_Services();
            List<Catalogue> catalogues = catservice.ObtenirAllCatalogues();
            return View(catalogues);
        }

        public IActionResult CreerCatalogue()
        {
            return View();
        }

        public IActionResult ModifierCatalogue(int catalogueid)
        {
            if (catalogueid != 0)
            {

                Catalogue_Services catalogueService = new Catalogue_Services();
                {
                    Catalogue catalogue = catalogueService.ObtenirAllCatalogues().Where(c => c.CatalogueID == catalogueid).FirstOrDefault();
                    if (catalogue == null)
                    {
                        return View("Error");
                    }
                    return View(catalogue);
                }
            }
            return View("Error");
        }

        /*public IActionResult ModifierCatalogue(int catalogueid)
        {
            if (catalogueid != 0)

        }*/

        [HttpPost]
        public IActionResult CreerCatalogue(Catalogue catalogue)
        {
            if (!ModelState.IsValid)
                return View();
            Catalogue_Services catalogueService = new Catalogue_Services();
            {
                catalogueService.CreerCatalogue(catalogue.CatalogueName, catalogue.Description);
                return RedirectToAction("Index");
            }
        }
    }
}
