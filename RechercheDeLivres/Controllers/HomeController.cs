using Microsoft.AspNetCore.Mvc;
using RechercheDeLivres.Models.DTOs;
using RechercheDeLivres.Services;

namespace seance_04_demo_01.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    List<Models.PageInfo> pagesInfo = new List<Models.PageInfo>(){
        //        new Models.PageInfo(){ Title = "First Title !", PageNumber = 25},
        //        new Models.PageInfo(){ Title = "Second Title !", PageNumber = 50}
        //    };
        //    return View(pagesInfo);
        //}

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(RechercheLivre recherche)
        {
            if (ModelState.IsValid)
                return RedirectToAction("Result", recherche);

            return View();
        }

        [HttpGet]
        public IActionResult Result(RechercheLivre recherche)
        {
            IRechercheLivresStrategy RechercheLivres = RechercheLivresStrategyFactory.Instance.GetRechercheStrategy();
            var resultats = RechercheLivres.Chercher(recherche);
            return View(resultats);
        }

        [HttpPost]
        public IActionResult Retour()
        {
            return RedirectToAction("Add");
        }
    }
}