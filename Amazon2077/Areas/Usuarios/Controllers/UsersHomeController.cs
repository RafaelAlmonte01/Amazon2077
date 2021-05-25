using Amazon2077.Areas.Usuarios.Models;
using Amazon2077.Controllers;
using Amazon2077.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon2077.Areas.Usuarios.Controllers
{
    [Area("Usuarios")]
    public class UsersHomeController : Controller
    {
      
            private readonly ILogger<UsersHomeController> _logger;
            private readonly dbUsuarioContext _db;

            public UsersHomeController(ILogger<UsersHomeController> logger, dbUsuarioContext db)
            {
                _logger = logger;
                _db = db;
            }
        public IActionResult Index()
        {
            var Usuarios = _db.Usuarios;
            return View(Usuarios);
        }

        public IActionResult Agregar()
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

