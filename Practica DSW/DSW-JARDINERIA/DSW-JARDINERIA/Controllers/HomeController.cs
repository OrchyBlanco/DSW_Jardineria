using DSW_JARDINERIA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DSW_JARDINERIA.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> localizador; //Internacionalizacion
        
        
        //Internacionalizacion

        public HomeController(IStringLocalizer<HomeController> localizador)
        {
            this.localizador = localizador;
        }
        //Fin Internacionalizacion
        [AllowAnonymous]
        public IActionResult Index()
        {
           ViewData["bienvenido"] = localizador["bienvenido"];
            return View();
        }
        
        public IActionResult Privacy()
        {
            ViewData["privacidad"] = localizador["privacidad"];
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
