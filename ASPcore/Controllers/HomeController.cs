using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASPcore.Models;

namespace ASPcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var a = new AlumnoModel();
            a.Nombre = "Carlos";
            a.App = "Cordova";
            a.Apm = "Lechuga";
            a.Carrera = "Informatica";
            a.NC = "17030081";
            a.Semestre = "1U";
            //____________________
            a.Nombre2 = "Omar";
            a.App2 = "Montoya";
            a.Apm2 = "Martinez";
            a.Carrera2 = "Informatica";
            a.NC2 = "17030091";
            a.Semestre2 = "7U";
            //____________________
            a.Nombre3 = "Elizabeth";
            a.App3 = "Chacon";
            a.Apm3 = "Arteaga";
            a.Carrera3 = "Medico Forence";
            a.NC3 = "17030082";
            a.Semestre3 = "5U";
            return View(a);

        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
