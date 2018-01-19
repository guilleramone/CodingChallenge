using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.DataAccess;

namespace CodingChallenge.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var titulos = new MockRepository().TituloRepository.GetTitulos();
            var resumen = Titulo.ImprimirResumen(titulos.ToList(), Idioma.Castellano);
            return View(resumen);
        }
    }
}