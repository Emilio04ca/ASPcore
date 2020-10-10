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
            Array aray;
            List<AlumnoModel> Alumnos = new List<AlumnoModel>();
            Alumnos.Add(new AlumnoModel{
                    NC = "17030081",
                    Nombre = "Carlos",
                    App = "Cordova",
                    Apm = "Lechuga",
                    Carrera = "Informatica",
                    Semestre = "1U"});
            Alumnos.Add(new AlumnoModel
            {
                NC = "17030091",
                Nombre = "Omar",
                App = "Montoya",
                Apm = "Martinez",
                Carrera = "Informatica",
                Semestre = "7U"
            });
            Alumnos.Add(new AlumnoModel
            {
                NC = "17030082",
                Nombre = "Elizabeth",
                App = "Chacon",
                Apm = "Arteaga",
                Carrera = "Medico Forence",
                Semestre = "5U"
            });


            aray = Alumnos.ToArray();
            ViewBag.alumnos = aray;
  
            return View();

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
