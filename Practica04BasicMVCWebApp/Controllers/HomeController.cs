using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practica04BasicMVCWebApp.Models;

namespace Practica04BasicMVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public string TestPage()
        {
            return "Saludo!";
        }

        public IActionResult TestPage2()
        {
            ViewData["Mensaje"] = "Página que utiliza una vista sin modelo";
            return View();
        }

        public IActionResult TestPage3()
        {
            
            Persona Karina = new Persona
            {
                Nombre = "Karina Rguez",
                Edad = 20
            };

            return View(Karina);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
