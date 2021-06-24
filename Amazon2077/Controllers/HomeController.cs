using Amazon2077.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon2077.Controllers
{
    public class HomeController : Controller
    {

 

        private readonly ILogger<HomeController> _logger;


        ProductosBL _bl = new ProductosBL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ListaProductos()
        {

            ViewBag.ListaProductos = _bl.ConsultarProductos().ToList();

            return View();
        }

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(ProductosEn pEN)
        {
            _bl.AgregarProducto(pEN);
           return RedirectToAction("ListaProductos");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
