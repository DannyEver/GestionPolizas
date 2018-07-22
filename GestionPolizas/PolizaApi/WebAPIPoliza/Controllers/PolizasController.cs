using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPIPoliza.Controllers
{
    public class PolizasController : Controller
    {
        // GET: Polizas

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CrearPoliza()
        {
            return View();
        }
    }
}